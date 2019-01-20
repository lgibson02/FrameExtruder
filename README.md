# Frame Extruder

Designed for getting around [edge bleeding issues](https://web.archive.org/web/20180411151113/http://rotorz.com/unity/tile-system/docs/edge-correction) found in the [Phaser](https://github.com/photonstorm/phaser) game engine when using spritesheets and tilesets. It works in the same way as the [tile-extruder](https://github.com/sporadic-labs/tile-extruder) by [@mikewesthad](https://github.com/mikewesthad) except it has a gui, does not have to be called from a terminal and doesn't require nodejs.

It is written in C# using Microsoft .NET 2.0 and has been designed and tested for use on Windows systems. For use on other operating systems, I would suggest trying Wine. The requirements for this program are fairly minimal so I suspect it will probably run on it without any problems, I haven't tested this though.

![](https://i.imgur.com/RlX1EyJ.png)
Here is a screenshot of the program running to show what it looks like. Here it runs in Windows 98, a useless but interesting "advantage" of using such an old version of .NET.

### Usage:
Usage is very simple, before selecting an image to use as a "frame sheet" (which is just my term to describe both tilesets and spritesheets), set the extrusion options to what you need them to be. Select the frame sheet by dragging an image file into the drag area or select manually. 

A table of available extrusion options and their function:

| Option                     | Function                                                                                            |    
| -------------------------- | :-------------------------------------------------------------------------------------------------- |
| Frame Width/Height         | The dimensions for a single frame in the original frame sheet.                                      |
| Margin                     | Number of pixels between frames and the edge of the original frame sheet                            |
| Spacing                    | Number of pixels between neighbouring tiles in original frame sheet.                                |
| Background Color           | Background color to use for extruded sheet, will show under spacing, margin and transparent pixels. |
| Save Copy Of Original Sheet| Save a copy of the original unextruded frame sheet.                                                          |
### Extrusion In Phaser:
Because of the extrusion, the margin and spacing will need to be adjusted for everything to look right. If you had no margin and spacing before, margin will be 1px and spacing will be 2px.
```javascript
// for tilesets...
const tileset = map.addTilesetImage("tileset", "tileset", 16, 16, 1, 2); // for a extruded 16x16 tileset
// for spritesheets
this.load.spritesheet("enemy", "enemy.png", {frameWidth: 16, frameHeight: 16, margin: 1, spacing: 2});
```

### Examples:
![](https://i.imgur.com/oT24Xhd.png)

**Tileset**:
![](https://i.imgur.com/durgSk3.png)

The results of extruding a single tileset using the default settings. Frame size 16x16 and no margin or spacing.


