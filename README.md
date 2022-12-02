# Cyftaud

Cyftaud is a free, open-source and easy-to-use tool to copy (zipped) folders to USB drives!

> **Note**: This program works on Windows operating systems only.

> **Warning**: This program is **NOT** meant to flash ISO images to USB drives! It only works for regular or zipped folders!

![](/Cyftaud/Resources/icon.png)  
*The Cyftaud icon*

![](/static/mainwindow.png)  
*The Cyftaud main window*

## Installing
You can simply run the EXE file you can find in the [releases](https://github.com/ILoveAndLikePizza/Cyftaud/releases)!

## Usage example
In this usage example, we are going to copy `msgcreator-usb.cyft` to `CYFTAUD (D:)`. This file contains installation files for [Message Box Creator](https://github.com/ILoveAndLikePizza/MessageBoxCreator).
### Open Cyftaud and load the file
This can be done in three ways:
- Simply run the EXE file, which can be found in the releases, choose [ZIP/CYFT folder] under *Folder*, click [Browse...] and choose the CYFT file;
- Select the CYFT file, right click it, select [Open With]... and choose Cyftaud;
- Run the EXE file from the terminal, with the path to the CYFT file as argument.
### USB drive settings
Select:
- the USB drive to copy to;
- whether files should be copied directly to the USB drive, or to a folder in the USB drive;
- if already existing files should be overwritten;
- if the USB should be erased before copying the files. (note that this is not the same as formatting the drive).
### Starting
If you have configured everything, you can click [Start!] to start copying the folder.  
Depending on your settings, you might get a warning for losing files. We are not responsible for (important) file loss!
When the progress bar at the bottom is full and the text next to it says *Done!*, everything has been copied.

## .cyft files
As demonstrated in the example above, this program can use `*.cyft` files.  
These files are exactly the same as `*.zip` files with another extension.  
This can be used to clarify that a file is meant to be copied to removable media.

# Have fun using Cyftaud!
