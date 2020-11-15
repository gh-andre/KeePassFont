<?xml version="1.0" encoding="utf-8"?>
<!--

  Copyright (c) 2020, gh-andre @ GitHub (https://github.com/gh-andre/KeePassFont)

-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="html">
  <xsl:output method="html" indent="yes"/>

  <!-- Change the value to 'no' to disable history output for each entry. -->
  <xsl:variable name="dump-history" select="'yes'" />

  <!-- HTML styles -->
  <xsl:template name="style">
    <style type="text/css">
      /* font sizes of all other elements are relative to this size */
      body {font-size: 14pt; font-family: sans-serif}
      pre {font-size: 0.8em}

      /* applies to all elements with borders */
      div.border {border-radius: 3px; border: 1px solid #999;}

      /* notes with line breaks for the database, groups and entries */
      div.database-notes,
      div.group-notes,
      div.entry-notes {margin-top: 0.2em; padding: 0.3em; background-color: #fafafa}

      div.database-notes pre,
      div.group-notes pre,
      div.entry-notes pre {margin: 0}

      /* main content div - contains everything else */
      div.content {margin: auto 2em;}

      /* database name and decription come from the meta elements and are different from the top database group */
      div.database-name {font-size: 1.2em; margin-bottom: 0; padding: 0.1em 0.2em 0.1em 0.5em; background-color: #f0f0f0;}

      /* all groups and entries of a group are wrapped in a `groups` div */
      div.groups {padding-left: 1em;}
      div.group {margin-top: 0.7em;}
      div.group-name {font-size: 1.2em; margin-bottom: 0; padding: 0.1em 0.2em 0.1em 0.5em; background-color: #f0f0f0;}

      /* all entries of a group are wrapped in an `entries` div */
      div.entries {padding-left: 1em;}
      div.entry {margin-top: 0.8em; padding: 0.3em 0.5em;}

      /* history uses same group and entry styles, which are wrapped in this div */
      div.history {margin-top: 0.8em; padding-left: 1em; border-left: 3px solid #ccc}

      /* created/modified times for each entry */
      div.entry-times {float: right; padding: 0.1em 0.2em; font-size: 0.8em; position: relative; top: -1.1em; background-color: #fffce6}

      /* each entry field is a line with a left-floating key div and a value in a div/span */
      div.entry-field {margin-top: 0.2em}
      div.key {width: 15%; float: left;}
      div.value {}
    </style>
  </xsl:template>

  <!-- Main HTML template -->
  <xsl:template match="/KeePassFile">
    <html>
    <head>
    <title><xsl:value-of select="Meta/DatabaseName" /></title>
    <xsl:call-template name="style" />
    </head>
    <body>
      <div class="content">
        <div class="meta">
          <div class="database-name border"><xsl:value-of select="Meta/DatabaseName"/></div>
          <xsl:if test="string-length(normalize-space(Meta/DatabaseDescription))">
            <div class="database-notes border">
              <pre><xsl:value-of select="Meta/DatabaseDescription"/></pre>
            </div>
          </xsl:if>
        </div>
        <div class="database">
          <xsl:apply-templates select="Root/Group" />
        </div>
      </div>
    </body>
    </html>
  </xsl:template>

  <!-- Group -->
  <xsl:template match="Group">
    <xsl:if test="UUID != /KeePassFile/Meta/RecycleBinUUID">
      <div class="group">
        <div class="group-name border"><xsl:value-of select="Name"/></div>

        <xsl:if test="string-length(normalize-space(Notes))">
          <div class="group-notes border">
            <pre><xsl:value-of select="Notes"/></pre>
          </div>
        </xsl:if>

        <xsl:if test="Entry">
          <div class="entries">
            <xsl:apply-templates select="Entry" />
          </div>
        </xsl:if>

        <xsl:if test="Group">
        <div class="groups">
          <xsl:apply-templates select="Group" />
        </div>
        </xsl:if>
      </div>
    </xsl:if>
  </xsl:template>

  <!-- Entry -->
  <xsl:template match="Entry">
    <div class="entry border ">
      <!-- created/modified times exist for every entry and tucked away in a box on the right -->
      <xsl:apply-templates select="Times"/>

      <!-- output most important on top -->
      <xsl:apply-templates select="String[Key = 'Title']" />
      <xsl:apply-templates select="String[Key = 'UserName']" />
      <xsl:apply-templates select="String[Key = 'Password']" />
      <xsl:apply-templates select="String[Key = 'URL']" />

      <!-- output other and custom fields; the latter may have line breaks, which are not rendered -->
      <xsl:apply-templates select="String[Key != 'Title' and Key != 'UserName' and Key != 'Password' and Key != 'URL' and Key != 'Notes']" />

      <!-- manufacture fields that are stored not as key/value pairs -->
      <xsl:apply-templates select="Tags"/>
      <xsl:apply-templates select="Times/Expires"/>
    </div>

    <!-- output notes on their own, so line breaks are visible -->
    <xsl:apply-templates select="String[Key = 'Notes']" />

    <!-- if there is history and history output is enabled, render historical entries -->
    <xsl:if test="$dump-history = 'yes' and History/Entry">
      <div class="history">
        <xsl:apply-templates select="History" />
      </div>
    </xsl:if>
  </xsl:template>

  <!-- Entry created/modified time stamps in an entry box on the right -->
  <xsl:template match="Entry/Times">
    <div class="entry-times border" title="created / modified">
      <xsl:value-of select="translate(CreationTime, 'T', ' ')"/>
      <xsl:text> / </xsl:text>
      <xsl:value-of select="translate(LastModificationTime, 'T', ' ')"/>
    </div>
  </xsl:template>

  <!-- Invocable key/value output template -->
  <xsl:template name="key-value-line">
    <xsl:param name="key" />
    <xsl:param name="value" />

    <div class="entry-field">
      <div class="key">
        <xsl:value-of select="$key" />
      </div>
      <div>
        <xsl:text>: </xsl:text>
        <span class="value"><xsl:value-of select="$value" /></span>
      </div>
    </div>
  </xsl:template>

  <!-- Outputs entry expiry time as a key/value pair, if entry expiry is set -->
  <xsl:template match="Times/Expires">
    <!-- output the time stamp only if Times/Entry is set to True -->
    <xsl:if test="text() = 'True'">
      <xsl:call-template name="key-value-line">
        <xsl:with-param name="key" select="'Expires'" />
        <xsl:with-param name="value" select="translate(../ExpiryTime, 'T', ' ')" />
      </xsl:call-template>
    </xsl:if>
  </xsl:template>

  <!-- Outputs a Key/Value pair of a String field -->
  <xsl:template match="Entry/String">
    <xsl:call-template name="key-value-line">
      <xsl:with-param name="key" select="Key" />
      <xsl:with-param name="value" select="Value" />
    </xsl:call-template>
  </xsl:template>

  <!-- Outputs entry non-empty tags as a key/value pair -->
  <xsl:template match="Entry/Tags">
    <xsl:if test="string-length(normalize-space(text()))">
      <xsl:call-template name="key-value-line">
        <xsl:with-param name="key" select="'Tags'" />
        <xsl:with-param name="value" select="text()" />
      </xsl:call-template>
    </xsl:if>
  </xsl:template>

  <!-- Outputs a non-empty entry Notes field as a preformatted field -->
  <xsl:template match="Entry/String[Key = 'Notes']">
    <xsl:if test="string-length(normalize-space(Value))">
      <div class="entry-notes border">
        <pre><xsl:value-of select="Value" /></pre>
      </div>
    </xsl:if>
  </xsl:template>

</xsl:stylesheet>
