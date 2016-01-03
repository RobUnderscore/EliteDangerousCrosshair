EliteDangerousCrosshair v1.21
=======================

Crosshair for Elite Dangerous to assist with piloting in Frameshift Mode/Docking. Download in the 'releases' section above.

Rewrote to deal with some FPS issues.

Original code at https://github.com/RobCubed/EliteDangerousCrosshair_original

========================
1.21 Changes:

 - Added compatibility for 64 bit client

1.2 Changes:

 - Added 'nubs' (toggleable) to the crosshair
 - Color picking for crosshairs (any color)
 - Opacity selector for crosshairs (from 0% to 100%)
 - All changes now persist across application launches - as soon as you select something, it changes

1.1 Changes:

- Optimized FPS loss (slower refresh rate, which is unnecessary unless you are moving or resizing the window)
- Added reticle size slider
- Added line thickness options
- Changed from a console window to a nicer looking form window
- Added icon to desktop

========================

Planned for the future:

- Additional crosshairs (possibly custom, choose a GIF/PNG etc)
- Switching from double buffered graphics to XNA/DirectX overlay (still not injecting into the game, simply a transparent window in Windows itself)

========================

Work in progress. ONLY works with Windowed mode. Does not hook into the DX at all, simply overlays a transparent click-through frame over your entire screen, and detects the location of the game window.

CTRL+SHIFT+F1 will enable and disable the crosshair.

Written using Visual Studio 2013 Community Edition, should compile fine in there.

Requires .NET 4.5.

KeyboardHook class is from http://www.liensberger.it/web/blog/?p=207
