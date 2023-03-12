using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblio_haus.Components
{
    public class BotaoArredondado : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // Define o estilo do botão como Flat
            this.FlatStyle = FlatStyle.Flat;

            // Remove as bordas do botão
            this.FlatAppearance.BorderSize = 0;

            GraphicsPath graphicsPath = new GraphicsPath();
            Rectangle rect = this.ClientRectangle;
            int radius = 10;

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




            this.Region = new Region(graphicsPath);

            base.OnPaint(e);
        }
    }
}