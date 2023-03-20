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
        }

        private void cardLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="teste" && txtSenha.Text == "123mudar")
            {
                new TelaInicial().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("O usuario informado esta incorreto, tente novamente!");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
