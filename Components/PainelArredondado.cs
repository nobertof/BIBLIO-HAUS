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
    public class PainelArredondado : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {

            Rectangle rect = this.ClientRectangle;
            int radius = 30;
            
            GraphicsPath panelPath = RoundedGraphicsPath.arredondar(rect, radius);

            this.Region = new Region(panelPath);

            base.OnPaint(e);
        }

    }
}