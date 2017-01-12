# DOS Console
A DOS console mode to immitate the DOS command with similar important function.

The following command are available in this application:

1.	CD (Change Directory) – Navigate between directories.
2.	Copy – Copy file(s) from source to target folder.
3.	Dir – List all files/directories in selected directory.
4.	MD (Make Directory) – Create new folders.
5.	RD (Remove Directory) – Delete existing folders.
6.	Move – Move file(s) from source to destination folder.
7.	Del – Deletes file(s)
8.	Rename - Renames a file/directory or files/directories.

Usage:

    - Change Directory
       CD..
       CD [Target Folder Full Path] i.e C:\test
       CD [Target Folder Name] i.e test

    - Copying or Moving File(s) from source to target folder
       COPY || MOVE [Source Folder]\* [Destination Folder]
       COPY || MOVE [Source Folder]\*.* [Destination Folder]
       COPY || MOVE [Source Folder]\*.[ext] [Destination Folder]
       COPY || MOVE [Source Folder]\[Exact Filename] [Destination Folder]
       COPY || MOVE [Source Folder]\[Filename].* [Destination Folder]

    - Deleting File(s) from a folder
       DEL [Source Folder]\*
       DEL [Source Folder]\*.*
       DEL [Source Folder]\*.[ext]
       DEL [Source Folder]\[Exact Filename]
       DEL [Source Folder]\[Filename].*

    - List all Files/Directories in selected directory
       DIR *
       DIR *.*
       DIR *.[ext]
       DIR [Filename].*
       DIR [Exact Filename]

    - Renaming File / Directory  or File(s) / Directories
       RENAME *.[old ext] *.[new ext]
       RENAME [Old File] [New File]
       RENAME [Old Folder] [New Folder]

    - Make Directory or Creating new folder
       MD [Directory Name]  i.e MD test
       MD [Fullpath folder and Directory Name] i.e MD C:\test

    - Remove Directory or Deleting existing folder
       RD [Directory Name] i.e RD test
       RD [Fullpath folder and Directory Name] i.e RD C:\test
