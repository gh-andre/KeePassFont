## Overview

This is a copy of KeePass v2.47 source, with a few changes described in
this file. See this page for the original application downloads and source
packages.

https://keepass.info/download.html

## Disclaimer

This repository is maintained to keep track of source changes and to share
the experience with other developers who may find these changes useful.
However, these steps and source changes have not been tested much and may
not work in other environments and may even cause unexpected results,
including possible loss of data. **Use these instructions and modified source
at your own risk.**

### Larger Application Font Size

All UI forms updated to use `10pt` font size instead of the original `8pt`,
which is very hard on the eyes, especially on high resolution monitors.

There are a few questions on KeePass forums about increasing font size and
many of them are either unanswered or described as _working as designed_.

https://sourceforge.net/p/keepass/discussion/search/?q=font+size

This repository is an attempt to address the need for larger fonts for those
who feel comfortable building this application from the source.

#### Display Resolution

These changes work best on high-resolution displays and were tested on a
display 3840x2160 with up to 200% display scaling on Windows 10.

Display resolution 1920x1080 was the lowest tested resolution and on some
displays it worked and on others some buttons were not be visible, depending
on display scaling and font scaling Windows settings.

If you build KeePass using these steps, make sure to go through application
dialogs you regularly use to check whether _Ok_ and _Cancel_ buttons are
visible before making any data changes or you will not be able to accept your
changes.

#### Building

These steps are tested on Windows 10 (x64) with Visual Studio 2019, Community
Edition. The original KeePass project was upgraded to Visual Studio 2019.

Download the source from this repository.

Run `cmd.exe` and run `vcvarsall.bat` from Visual Studio installation to set
up x64 build environment.

    vcvarsall.bat x64

In the command prompt window, change to the directory with this source and
start Visual Studio from the the same command prompt, so it can find
`sgen.exe`, which is referenced in the solution.

    devenv KeePass.sln

Change the solution configuration to `Release`, platform to `Any CPU`, startup
project to `KeePass` and attempt to build it. The build will fail with this error,
except that Visual Studio key will be different. Copy the key value.

> Cannot import the following key file: KeePass.pfx. The key file may
> be password protected. To correct this, try to import the certificate again
> or manually install the certificate to the Strong Name CSP with the following
> key container name: VS_KEY_27A70973F3FC3787

Go back to the command prompt and import PFX keys with this command, but using
the Visual Studio key from the error above.

    sn -i KeePass\KeePass.pfx VS_KEY_27A70973F3FC3787

Enter the password for the PFX key, which is described in `ReadMe_PFX.txt`
and is `123123` on the moment of this writing.

In the command prompt window, run this command to confirm that .Net framework
SDK is located in the same directory as described below.

    set | findstr /C:"WindowsSDK"

You should see the line that starts with `WindowsSDK_ExecutablePath_x64`,
which is where `sgen.exe` is located. If you don't see this line, you need to
find `sgen.exe` in your environment and adjust following steps to run `sgen.exe`
from your location.

In the solution, open `KeePass` project's properties and go to `Build Events`.
You will see the `Post Build` event, which contains this text, except that
ellipsis in the text below are for readability. Note the Visual Studio key.

    "$(WindowsSDK_ExecutablePath_x64)sgen.exe" ... /compiler:/keycontainer:VS_KEY_27A70973F3FC3787 ...

Replace the Visual Studio key with your key. Leave other text unchanged.

Build the solution and make sure all three projects build without errors.
There will be a couple of warnings about XML properties. Ignore those.

Note that the application built this way will not be digitally signed in a
way accepted by Windows 10 and if your **Smart Screen** is turned on, it will
pop up a warning that the application is not signed. You will need to click
_More info_ and the click to run the app anyway.

#### Changing Font Size

Visual Studio is buggy in the handling high DPI settings and dialogs failed to
resize automatically unless these steps were followed. Follow the _Build_ steps
to make sure Visual Studio builds properly these changes.

* Click the form whose font size you would like to change, such as `AboutForm.cs`.
* The dialog editor may appear empty and you need to minimize/restore Visual Studio
  IDE window to see the dialog. This appears to be a bug in Visual Studio. 
* Visual Studio will present a pop-up line at the top asking if you would like
  to restart Visual Studio with display scaling. Go ahead and restart.
* Double-click the form again and go to _Properties_ in the solution explorer.
* Click the font picker in the _Font_ proprty line. Choose font size `10pt`.
  The dialog may appear to have a larger outline, but all controls will still
  be in the same locations as before.
* Scroll down to `AutoScaleMode` in _Layout_ and change it from `Font` to `Dpi`.
  You should see the dialog rendered properly in Visual Studio.

Once this is done, build the app and run it from Visual Studio and test the
dialog you changed to make sure it is rendered properly.

#### Installing

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

, and rename the original `KeePass.exe` file. Do not delete it. Copy the new `KeePass.exe`
you just built and tested into the installation directory.

It's worth noting that this step replaces only the executable and not the KeePass
library, which implements encryption and other secure algorithms.

Launch the new KeePass application and test that it works in every way in how
you normally use the application.

#### Final Notes

Before installing a new version of KeePass, restore the original `KeePass.exe`
file.

## XSL Template to Export All Fields and History

KeePass comes with excellent data export capabilities, but the bundled XSL
stylesheets do not export entry history, collapse entry notes, drop group
notes and group hierarchy.

Being able to search through password history is quite important for those
who want to track down some old compromised passwords and KeePass does not
offer history search in the application either.

The new XSL template [KDBX_Dump_HTML.xsl](Ext/XSL/KDBX_Dump_HTML.xsl)
outputs all fields, including history, and preserves the group hierarchy
in the output. It also recognizes the recycle bin group and omits it from
the output.

History may be disabled by changing the following line in the XSL source
to look like this:

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
XML and generated HTML are saved in some encrypted storage, such as a BitLocker
folder or a USB drive attached via a hardware encryption key.

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

