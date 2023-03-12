using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblio_haus.Components
{
    public class PainelArredondado : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {

            GraphicsPath panelPath = new GraphicsPath();
            Rectangle rect = this.ClientRectangle;
            int radius = 30;
            panelPath.StartFigure();
            panelPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            panelPath.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y);
            panelPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            panelPath.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius);
            panelPath.AddArc(rect.X + rect.Width - radius,
                             rect.Y + rect.Height - radius, radius, radius, 0, 90);
            panelPath.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height);
            panelPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            panelPath.CloseFigure();
            this.Region = new Region(panelPath);

            base.OnPaint(e);
        }

    }
}