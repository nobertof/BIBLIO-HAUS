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
    public class RoundedTextBox : Panel
    {
        private Label lbl;
        private TextBox txt;
        private PictureBox pic;
        private GraphicsPath shape;

        public RoundedTextBox(string label, int width, int height)
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(5);

            lbl = new Label();
            lbl.AutoSize = true;
            lbl.Dock = DockStyle.Top;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lbl.ForeColor = Color.Gray;
            lbl.Text = label;

            txt = new TextBox();
            txt.BorderStyle = BorderStyle.None;
            txt.Dock = DockStyle.Bottom;
            txt.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txt.ForeColor = Color.FromArgb(64, 64, 64);

            pic = new PictureBox();
            pic.Dock = DockStyle.Left;
            pic.Padding = new Padding(5);

            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            this.Controls.Add(pic);
            this.BackColor = Color.Red;
            this.Width = width;
            this.Height = height;
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            GraphicsPath panelPath = RoundedGraphicsPath.arredondar(this.ClientRectangle, 20);
            this.Region = new Region(panelPath);

            base.OnPaint(e);
        }
    }
}