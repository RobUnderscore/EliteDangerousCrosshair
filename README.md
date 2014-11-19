EliteDangerousCrosshair v.1.1
=======================

Crosshair for Elite Dangerous to assist with piloting in Frameshift Mode/Docking

Rewrote to deal with some FPS issues.

Original code at https://github.com/RobCubed/EliteDangerousCrosshair_original

========================

v1.1 Changes:

- Optimized FPS loss (slower refresh rate, which is unnecessary unless you are moving or resizing the window)
- Added reticle size slider
- Added line thickness options
- Changed from a console window to a nicer looking form window

========================

Work in progress. ONLY works with Windowed mode. Does not hook into the DX at all, simply overlays a transparent click-through frame over your entire screen, and detects the location of the game window.

CTRL+SHIFT+F1 will enable and disable the crosshair.

Written using Visual Studio 2013 Community Edition, should compile fine in there.

Requires .NET 4.5.

KeyboardHook class is from http://www.liensberger.it/web/blog/?p=207
