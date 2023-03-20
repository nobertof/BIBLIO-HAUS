using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;

namespace biblio_haus.Utils
{
    public class RoundedGraphicsPath
    {
        public static GraphicsPath arredondar(Rectangle rect, int radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            graphicsPath.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y);
            graphicsPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            graphicsPath.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius);
            graphicsPath.AddArc(rect.X + rect.Width - radius,
                             rect.Y + rect.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height);
            graphicsPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }
    }
}