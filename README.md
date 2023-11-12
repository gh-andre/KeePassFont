## Overview

This is a copy of KeePass v2.55 source, with a few changes described in
this file. See this page for the original application downloads and source
packages.

https://keepass.info/download.html

## Disclaimer

This repository is maintained to keep track of source changes and to share
the experience with other developers who may find these changes useful.
However, these steps and source changes have not been tested much and may
not work in other environments and may even cause unexpected results,
including possible loss of data. **Use these instructions, modified source
and build artifacts at your own risk.**

## Changes

### Application Font Size

All UI forms in this repository are updated to use `11pt` font size instead
of the original `8pt`, which is very hard on the eyes, especially on high
resolution displays.

There are a few questions on KeePass forums about increasing font size
and many of them are either unanswered, answered dismissively or described
as _working as designed_.

https://sourceforge.net/p/keepass/discussion/search/?q=font+size

The authors of this otherwise brilliant application seem to be unaware
of display and font scaling and the difference between physical and
effective pixels. This repository is an attempt to address the need for
larger fonts in KeePass for those who feel comfortable building it from
the source.

Note that starting with v2.55.0, the target font size was changed from
`10pt` to `11pt` in this repository, which works best on 4K displays.
However, this may result in some dialogues rendered partially cut off
on displays with lower resolutions. Make sure to test large dialogues,
such as generating master passwords or the options dialogues, before
switching to this version.

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

The original KeePass source is always committed on `master` and tagged
with the original version number. All changes are maintained in version
branches, which contain cherry-picked changes from the previous version
and new changes. Current topology looks like this:

    
           VS2019    8pt/10pt        VS2019   8pt/10pt
              |         |               |        |   
           +--o---------o----->     +---o--------o---->      +---... v2-48-1
          /                v2-46-0 /               v2-47-0  /   
    -o---o------------------------o----o-------------------o---o---> master
     |  README.md                 |   README.md            |  README.md
    keepass-2-46-0            keepass-2-47-0           keepass-2-48-1

Version branches `v2-46-0`, `v2-47-0` and `v2-48-1` contain modifications
of the original code, which is maintained in `master` and is tagged with
`keepass-2-46-0`, `keepass-2-47-0` and `keepass-2-48-1`, respectively, for
each new source drop.

The `master` branch contains original KeePass source and two additional
files, `.gitignore` and `README.md`. The latter is required for GitHub to
show README on the repository home page. `README.md` on `master` should
be cherry-picked from the latest version branch for each new modified
source drop.

### Importing KeePass Source

New KeePass source is imported using following steps.

* If you maintain Visual Studio key patch as a stash on a version branch,
  push it onto the stash stack:

      git stash push KeePass\KeePass.csproj

* Checkout `master`

      git checkout master

* Delete all source, except `.git`, `.gitignore`, `.github`, `README.md`
  and, perhaps, `.vs`.
* Unzip the new source archive.
* Add all new source, commit and tag with `keepass-x-y-z`, where `x-y-z`
  would be the actual version, such as `keepass-2-48-1`.
* Create a new branch for changes to the new version, with an actual
  version instead of `x-y-z` (e.g. `v2-48-1`).

      git checkout -b vx-y-z

* Remove the `.github` directory with the empty GitHub workflow from
  the main branch and commit the change. This will prevent conflicts
  when the full GitHub workflow is cherry-picked from the previous
  release branch.
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
  additional changes and should be cherry-picked to `master`.

## Building

These steps are tested on Windows 10 (x64) with Visual Studio 2022, Community
Edition. The original KeePass project was upgraded to Visual Studio 2022.

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
and maintain release packages with relevant files, which can be used as
the installation source instead of the local build output.

## Installing

Install the standard version of KeePass downloaded from the application website:

https://keepass.info/download.html

Before opening the actual password file with the application built above, launch
the installed KeePass application and create a test database with a few passwords.
Do not open your actual password file until you tested the new application.

Once you have a test database, launch the application you just built from this
directory:

    KeePass\Build\KeePass\Release\KeePass.exe

Open the test database and make sure the functionality you typically use still
works and you can see all buttons in the dialogs.

Backup your actual password file before you open it with the new application.

Open the KeePass installation directory:

    C:\Program Files (x86)\KeePass Password Safe 2

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

Follow the _Build_ steps to make sure Visual Studio can build these changes,
so you can check whether font changes work or not.

Visual Studio is very buggy in handling forms and DPI settings and depending
on the version of Visual Studio, it may not work as described.

Font changes need to be applied in two steps. Do not change `MainForm_Events.cs`
and `MainForm_Functions.cs` forms in either of these steps.

For the first step, Visual Studio must be switched to 100% scaling mode,
as described below.

* Launch Visual Studio as described in _Building_
* Expand the `Forms` solution folder and click `AboutForm.cs`. The form
  editor may appear empty and you need to minimize/restore Visual Studio
  IDE to see the form.
* Visual Studio will present a pop-up line at the top asking if you
  would like to restart Visual Studio with 100% display scaling. Click
  to restart with 100% scaling.
* For every form, change the `Font` property from `8pt` to `11pt` and
  `AutoScaleMode` property from `Font` to `Dpi`. Font size must be
  changed first or the form will not be resized proportionally to
  accommodate resized fields.
* Once all forms have been changed, exit Visual Studio.

For the second step, Visual Studio must be running in the default display
scaling mode.

* Launch Visual Studio as described in _Building_
* Dismiss the prompt to switch to 100% display scaling mode without
  switching.
* For every form, find a simple `True`/`False` property, such as _Behavior/
  Enabled_ and flip it twice to its original value.
* Build the app and run it from Visual Studio to test whether forms are
  rendered without controls overlapping and there is no truncated text.

The third step makes very little sense, but is required for some forms
to render correctly. For example, `GroupForm.Designer.cs` and
`TanWizardForm.Designer.cs` will have overlapping controls without this
step. If you know a better way to avoid this, please start a discussion.

These steps are very tedious and error-prone. It helps to open all
forms at once via a _Click_ followed by _Shift-Double-Click_ for
multiple forms, skipping those that should not be edited, and edit
them one after another, closing updated and saved forms throughout
the process.

### Display Resolution

These changes were tested on 3840x2160 displays, with up to 200% display
scaling, and 1920x1080 displays on Windows 10. On one of of the lower
resolution displays some buttons were not visible for some display scaling
and font scaling combinations.

Make sure to go through application dialogs you regularly use to check
whether _Ok_ and _Cancel_ buttons are visible before making any data changes
or you will not be able to accept your changes.

## Issues

This repository has nothing to do with KeePass functionality and application
issues should be addressed via the application website.

https://keepass.info/

If you experience any issues with application dialogs display, simply switch back
to the original application.

If you find something missing from build instructions in this file, such as
inappropriate mix of some .Net assemblies between installed and built application,
create an issue here.

Similarly, if you find bugs in `KDBX_Dump_HTML.xsl`, also create an issue here.
