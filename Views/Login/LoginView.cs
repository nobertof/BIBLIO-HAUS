using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblio_haus.Models;
using System.Linq;



namespace biblio_haus.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            this.Resize += Form1_SizeChanged;
            cardLogin.Paint += new PaintEventHandler(panel1_Paint);
        }


    }
}
