using System.Drawing;
using Oxage.Wmf;

namespace Irish
{
    class Program
    {
        const int STRIP_WIDTH = 85;
        static void Main(string[] args)
        {
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
        }
    }
}
