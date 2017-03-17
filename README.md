# Various ways to draw a (vector) Irish Flag #

☘️☘️☘️ Happy St. Patrick's y'all! :beer: :beers: :beer:


## Source image: JPEG (255x128 raster) : 956 bytes ##

![](irish-flag.jpg?raw=true)
from [Reddit](https://www.reddit.com/r/europe/comments/5zwm5z/happy_saint_patricks_day_europe/)


## Scalable Vector Graphics : 171 bytes; 144 bytes gzipped

[irish-flag.svgz](irish-flag.svgz) (gzip-compressed version of [irish-flag.svg](irish-flag.svg))

```svg
<svg xmlns="http://www.w3.org/2000/svg" width="255" height="128"><rect fill="#009B48" width="85" height="128"/><rect fill="#FF7900" x="170" width="85" height="128"/></svg>
```


## Encapsulated PostScript : 279 bytes ##

[irish-flag.eps](irish-flag.eps)

```eps
%!PS-Adobe-3.0 EPSF-3.0
%%BoundingBox: 0 0 255 128
%%BeginProlog
userdict begin
/re { exch dup neg 3 1 roll 5 3 roll moveto 0 rlineto 0 exch rlineto 0 rlineto closepath } bind def
%%EndProlog
0 .61 .28 setrgbcolor
0 128 85 -128 re fill
1 .47 0 setrgbcolor
170 128 85 -128 re fill
```


## Windows MetaFile : 178 bytes ##

Binary GDI instructions. Generated using [Oxage.Wmf .NET library](https://wmf.codeplex.com/)

[irish-flag.wmf](irish-flag.wmf)

```c#
            var wmf = new WmfDocument();
            wmf.Width = STRIP_WIDTH * 3;
            wmf.Height = (STRIP_WIDTH * 3 + 1) / 2;

            wmf.AddCreatePenIndirect(Color.Black, PenStyle.PS_NULL, 0);
            wmf.AddSelectObject(0);

            wmf.AddCreateBrushIndirect(Color.FromArgb(0x00, 0x9B, 0x48), BrushStyle.BS_SOLID);
            wmf.AddSelectObject(1);
            wmf.AddRectangle(0, 0, STRIP_WIDTH, 128);
            wmf.AddDeleteObject(1);

            wmf.AddCreateBrushIndirect(Color.FromArgb(0xFF, 0x79, 0x00), BrushStyle.BS_SOLID);
            wmf.AddSelectObject(1);
            wmf.AddRectangle(2 * STRIP_WIDTH, 0, STRIP_WIDTH, 128);

            wmf.Save(@"irish-flag.wmf");
```


## HTML Canvas + JavaScript : 206 bytes ##

[irish-flag-canvas.html](irish-flag-canvas.html)

```html
<canvas id=c width=255 height=128/><script>c=document.querySelector('#c').getContext("2d");c.beginPath();c.fillStyle='#009B48';c.fillRect(0,0,85,128);c.fillStyle='#FF7900';c.fillRect(170,0,85,128);</script>
```


## Indexed 2-bpp PNG : 164 bytes (raster format, not vector) ##

Used the [PNGoo GUI](https://pngquant.org/), based on [pngquant](https://github.com/pornel/pngquant), both developed by Kornel Lesiński and contributors.

![](irish-flag.png?raw=true)
