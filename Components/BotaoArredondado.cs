using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblio_haus.Utils;

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

            Rectangle rect = this.ClientRectangle;
            int radius = 10;
            
            GraphicsPath graphicsPath = RoundedGraphicsPath.arredondar(rect, radius);

            this.Region = new Region(graphicsPath);

            base.OnPaint(e);
        }
    }
}