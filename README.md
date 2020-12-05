# Just Cause 3 | Intro-Remover
Program to skip the unnecessary intro in Just Cause 3.

This guide will show you, how you can skip the long unnecessary intro in Just Cause 3.

1. Download the .exe [here](https://github.com/aveniir/Just-Cause-3-Intro-Remover/releases) and start it.

2. Open your JC3 directory.

Right-click Just Cause 3 in you Steam library.
Choose "Properties".
Change to the "Local Files" tab.
Click "Browse Local Files...".

3. Paste the path into the program and press enter.

4. On Steam, you're going to need to add a few commandline arguments to enable the dropzone directory:

You can easily set this through Steam by right-clicking Just Cause 3,
Choose "Properties".
Click "Set Launch Options...".

If you don't have any DLC's installed, add this:  

`--vfs-fs dropzone --vfs-archive patch_win64 --vfs-archive archives_win64 --vfs-fs .`

And if you do have any DLC's installed, add this:  

`--vfs-fs dropzone --vfs-archive patch_win64 --vfs-archive archives_win64 --vfs-archive dlc_win64 --vfs-fs .`

Paste the arguments line into the text box, and click "OK".

And that's it!
If you have any questions, feel free to ask me in the comments, or add me [on Steam](https://steamcommunity.com/id/aveniir/).
