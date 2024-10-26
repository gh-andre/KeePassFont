## Overview

This is a copy of KeePass v2.57.1 source, with a few changes described in
this file. See this page for the original application downloads and source
packages.

https://keepass.info/download.html

## Disclaimer

This repository is maintained to keep track of source changes and to
share the experience with other developers who may find these changes
useful. However, these steps and source changes have not been tested
beyond personal use and may not work in other environments and may
even cause unexpected results, including possible loss of data.
**Use these instructions, modified source and build artifacts at your
own risk.**

## Changes

### Application Font Size

All UI forms in this repository are updated to use `11pt` font size instead
of the original `8pt`, which is very hard on the eyes, especially on high
resolution displays.

There are a few questions on KeePass forums about increasing font size
and many of them are either unanswered, answered dismissively or described
as _working as designed_.

https://sourceforge.net/p/keepass/discussion/search/?q=font+size

The official advice given on the page below is to increase the display
scaling, which actually affects all applications, and if it is changed
to make KeePass readable, it would render all other applications
unusable because of the system-wide excessive scaling. In addition to
this, the advice given with regards to not using the _Accessibility_
settings is counterproductive, as these settings play very important
role in scaling font size in many applications, such as File Explorer
or Chrome.

https://keepass.info/help/base/faq_tech.html#guifont

This repository is an attempt to address the need for larger fonts
in KeePass for those who feel comfortable building it from the source.

A bug was created for Visual Studio in that automatic form scaling
does not compute form layout correctly when display scaling changes
at application run time from what it was when Visual Studio was
running, but it was closed with an unusable suggested work-around.
Add a _No_ vote in this thread if you agree that this problem should
be addressed in Visual Studio.

https://developercommunity.visualstudio.com/t/Net-form-scaling-does-not-work-in-Visua/10768347#T-N10774244

### XSL Template to Export All Fields and History

KeePass comes with excellent data export capabilities, but the bundled XSL
style sheets do not export entry history, collapse entry notes, drop group
notes and group hierarchy.

Being able to search through password history is quite important for those
who want to track down some old compromised passwords and KeePass does not
offer history search in the application either.

The new XSL template `Ext/XSL/KDBX_Dump_HTML.xsl` outputs all fields,
including history, and preserves the group hierarchy in the output. It
also recognizes the recycle bin group and omits it from the output.

History output may be disabled by changing the following line in the XSL
source to look like this:

    <xsl:variable name="dump-history" select="'no'" />

Output font size and other CSS properties may be changed in the XSL at the
top of the source file.

`KDBX_Dump_HTML.xsl` may be used in two ways. You can copy this file into
the XSL folder in the KeePass installation folder, where other XSL templates
are, and use it via KeePass' export functionality. Alternatively, you can
export KeePass XML file and use a standalone XSL processor to produce the
HTML. For example, using `msxsl.exe`:

    msxsl MyKeePass.xml KDBX_Dump_HTML.xsl -o MyKeePass.html

The latter provides greater flexibility, but you must ensure that exported
XML and generated HTML are saved in some encrypted storage, such as a
BitLocker drive or a USB drive attached via a hardware encryption key.

## Repository Structure

The original KeePass source is always committed on `main` and tagged
with the original version number. All changes are maintained in version
branches, which contain cherry-picked changes from the previous version
and new changes. Current topology looks like this:

    
           VS2019    8pt/10pt        VS2019   8pt/10pt
              |         |               |        |   
           +--o---------o----->     +---o--------o---->      +---... v2-48-1
          /                v2-46-0 /               v2-47-0  /   
    -o---o------------------------o----o-------------------o---o---> main
     |  README.md                 |   README.md            |  README.md
    keepass-2-46-0            keepass-2-47-0           keepass-2-48-1

Version branches `v2-46-0`, `v2-47-0` and `v2-48-1` contain modifications
of the original code, which is maintained in `main` and is tagged with
`keepass-2-46-0`, `keepass-2-47-0` and `keepass-2-48-1`, respectively, for
each new source drop.

The `main` branch contains original KeePass source and two additional
files, `.gitignore` and `README.md`. The latter is required for GitHub to
show README on the repository home page. `README.md` on `main` should
be cherry-picked from the latest version branch for each new modified
source drop.

### Importing KeePass Source

New KeePass source is imported using following steps.

* Checkout `main`

      git checkout main

* Delete all source, except `.git`, `.gitignore`, `.github`, `README.md`
  and, perhaps, `.vs`.
* Unzip the new source archive.
* Add all new source, commit and tag with `keepass-x-y-z`, where `x-y-z`
  would be the actual version, such as `keepass-2-48-1`.
* Create a new branch for changes to the new version, with an actual
  version instead of `x-y-z` (e.g. `v2-48-1`).

      git checkout -b vx-y-z

* Upgrade solution to Visual Studio 2022, remove `UpgradeLog.htm`
  and commit changes.
* Retarget all projects to use the .Net Framework v4.8. The original
  .Net v4.0 is no longer installed on GitHub runners. Note, however,
  that very little testing was done with running a mix of original
  KeePass DLLs built with .Net v4 with the UI component built with
  .Net v4.8.
* Cherry-pick non-conflicting changes from the previous version branch,
  which typically includes added files, such as the new XSL template.
  For example, if `12345678` represents a commit with the last
  non-conflicting change for version 2.47.0, the cherry-pick command
  for version 2.48.0 would look like this:

      git cherry-pick keepass-2-47-0..12345678

  If the first commit has conflicts, you will need to cherry-pick changes
  individually.
* Trying to cherry-pick font size changes from the previous branch would
  be quite error-prone, given how Visual Studio maintains form layout
  in the source, so font size changes should be applied manually at this
  point.
* Once font size changes are applied, tested and committed, `README.md`
  should be updated to reflect the new application version and any
  additional changes and should be cherry-picked to `main`.

## Building

These steps are tested on Windows 10/11 (x64) with Visual Studio 2022,
Community Edition. The original KeePass project was upgraded to Visual
Studio 2022.

Clone this repository and check out the version branch you would like to build.

    git checkout v2-50-1

Run `cmd.exe` and run `vcvarsall.bat` from Visual Studio installation to set
up x64 build environment.

    vcvarsall.bat x64

The original solution is configured to sign KeePass binaries with a
dummy `KeePass.pfx`, which cannot be automated because it requires
user input in importing this key file on the build machine. This key
file was removed from the repository and all projects were modified
not to sign build output.

Note that the application built this way will not be digitally signed and
if your **Smart Screen** is turned on, it may pop up a warning that the
application is not signed. You will need to click _More info_ and then
click the button to run the app anyway.

Start Visual Studio from the the same command prompt, so it can find
`sgen.exe`, which is referenced in the solution, in post build events
of the `KeePass` project.

    devenv KeePass.sln

Change the solution configuration to `Release`, platform to `Any CPU`,
startup project to `KeePass` and build the solution.

## GitHub Releases

This repository is configured to build `KeyPass.exe` as described above
and maintains release packages with relevant files, which can be used as
the installation source instead of the local build output.

The package with the `150pct` in the name is intended for Windows
configurations with the primary display scaled at 150% and the one with
`200pct` in the name is intended for the primary display scaled at
200%.

## Installing

Install the official version of KeePass matching the version in this
repository from the application website:

https://keepass.info/download.html

Before opening the actual password file with the application built above, launch
the installed KeePass application and create a test database with a few passwords.
Do not open your actual password file until you tested the new application.

Once you have a test database, launch the application you just built from this
directory:

    KeePass\Build\KeePass\Release\KeePass.exe

Open the test database and make sure the functionality you typically use still
works and you can see all buttons in the forms.

Backup your actual password file before you open it with the new application.

Open the KeePass installation directory, which will be one of these:

    C:\Program Files (x86)\KeePass Password Safe 2
    C:\Program Files\KeePass Password Safe 2

, and rename the original `KeePass.exe` and `KeePass.XmlSerializers.dll` files.
Do not delete them. Copy the new files you just built and tested into the
installation directory.

It's worth noting that this step replaces only the executable and not the KeePass
encryption library, which implements encryption and other secure algorithms.

Launch the new KeePass application and test that it works in every way in how
you normally use the application.

Before installing a new version of KeePass, restore the original `KeePass.exe`
and `KeePass.XmlSerializers.dll` files.

## Changing Font Size

### Overview

Visual Studio is buggy and inconsistent in handling forms and DPI settings
and depending on the version of Visual Studio, it may not work as described.

Note that on a two-display systems, the scaling of the primary display
is used by Visual Studio, even if it is running on the secondary display.
This makes it very confusing and error-prone in reworking forms, as
described below.

For example, if the primary display is a laptop screen with 150% display
scaling and the secondary display is a 4K display with 200% display
scaling, then running Visual Studio on the secondary display will change
forms such that they are suitable for displays scaled at 150%, _not_ for
displays scaled at 200%. If, however, the laptop display lid is closed,
then the 4K display becomes the primary display, and forms are created
with measurements appropriate for this 200% scaling configuration.

What is worse, is that DPI scaling implemented by Visual Studio is not
consistent, so if the app is built for the display scaled at 150%, then
running this app on a primary display scaled at 200% will compute all
multi-line text boxes, such as those in the _Change Master Key_ form,
to grow by 50%, even though the form will not be, so the text in those
text boxes will be rendered as if the form is 50% wider and the middle
part of it will not be visible.

This means that at the time of this writing, you would need to run
KeePass built from this repository on the exact same display scaling
as it was when the forms were resized. Hopefully, a better way will
be found in the future, but this is how it is at this time.

When testing the application built from this repository, try opening
larger forms, such as _File > Change Master Key_, to check if all of
the buttons are visible and also whether the text that wraps on the
right contains incomplete sentences.

### Steps

Follow the _Build_ steps to make sure Visual Studio can build these changes,
so you can check whether font changes work or not.

Font changes need to be applied in two steps. Do not change `MainForm_Events.cs`
and `MainForm_Functions.cs` forms in either of these steps.

Make sure the C# editor is set to use 4-space tab indents to make changes
more concise and visible.

For the first step, Visual Studio must be switched to 100% scaling mode,
as described below.

* Launch Visual Studio with 100% scaling:

      devenv /noscale KeePass.sln

* Select all forms in the solution, under _Forms_, except `MainForm_Events.cs`
  and `MainForm_Functions.cs`. Right-click on the selection and select
  `Open`.
* Visual Studio will present a pop-up line at the top asking if you
  would like to restart Visual Studio without scaling. Dismiss this
  prompt without accepting.
* For every form, change the `Font` property from `8pt` to `11pt` and
  `AutoScaleMode` property from `Font` to `Dpi`. Font size must be
  changed first or the form will not be resized proportionally to
  accommodate resized fields.
* It helps to change the form and close it via keyboard (typically Ctrl-F4)
  while going through all forms, so only unchanged forms remain visible.
* Once all forms have been changed, exit Visual Studio.

For the second step, Visual Studio must be running in the default display
scaling mode.

* Launch Visual Studio with the current scaling factor:

      devenv KeePass.sln

* Open all forms the same way as described above
* Dismiss the prompt to switch to 100% display scaling mode without
  switching.
* For every form, find a simple `True`/`False` property, such as
  _Behavior/Enabled_ and flip it twice to its original value.
* Build the app and run it from Visual Studio to test whether forms
  are rendered without controls overlapping and there is no truncated
  text.

These steps make very little sense, but is required for forms to
render correctly.

The forms listed below have multi-line fields with long text, which
may be truncated at the end for some display scaling values. Check
each in Visual Studio, and if the text is truncated, pull the bottom
of these fields down a few pixels to show the entire sentences.

* AboutForm.Designer.cs
* DatabaseOperationsForm.Designer.cs
* IOConnectionForm.Designer.cs
* KeyCreationForm.Designer.cs
* PwGeneratorForm.Designer.cs

All forms may be reset to their original versions via this command.
Note that in order to use this command in a batch script, `%p` should
be changed to `%%p`.

    for /F %p in ('dir /B KeePass\Forms\*.Designer.cs') do (
        git show keepass-2-57-1:KeePass/Forms/%p > KeePass\Forms\%p
    )

The best form to experiment on is `KeyCreationForm.Designer.cs`,
and if font changes applied against this form render properly, then
all other forms will likely work just as well.

## Issues

This repository has nothing to do with KeePass functionality and application
issues should be addressed via the application website.

https://keepass.info/

If you experience any issues with application forms display, simply switch back
to the original application.

If you find something missing from build instructions in this file, such as
inappropriate mix of some .Net assemblies between installed and built application,
create an issue here.

Similarly, if you find bugs in `KDBX_Dump_HTML.xsl`, also create an issue here.
