
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using biblio_haus.Constants;
using System.Drawing.Drawing2D;
using biblio_haus.Components;

namespace biblio_haus.Views
{
    partial class LoginView
    {


        private System.ComponentModel.IContainer components = null;

        // Criação dos controles
        private Label labelUsuario;
        private Label labelSenha;
        private TextBox campoUsuario;
        private TextBox campoSenha;
        private BotaoArredondado botaoLogin;
        private PainelArredondado cardLogin;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Text = "Login";
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = Theme.PRIMARY_COLOR;
            this.MinimumSize = new Size(500, 500);

            //Criando o card
            cardLogin = new PainelArredondado();
            cardLogin.BackColor = Color.White;
            cardLogin.Location = new Point(20, 20);
            cardLogin.Size = new Size(300, 200);
            cardLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            cardLogin.Dock = DockStyle.None;
            cardLogin.MinimumSize = new Size(300, 300);
            cardLogin.MaximumSize = new Size(500, 500);
            cardLogin.Location = new Point((this.ClientSize.Width - cardLogin.Width) / 2, (this.ClientSize.Height - cardLogin.Height) / 2);

            // Configuração dos controles
            labelUsuario = new Label();

            labelUsuario.Location = new Point(30, 50);
            labelUsuario.Text = "Usuário:";
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.FlatStyle = FlatStyle.Flat;
            cardLogin.Controls.Add(labelUsuario);

            campoUsuario = new TextBox();

            campoUsuario.Location = new Point(130, 50);
            campoUsuario.MinimumSize = new Size(100, 0);
            campoUsuario.MaximumSize = new Size(200, 0);
            campoUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            cardLogin.Controls.Add(campoUsuario);

            labelSenha = new Label();

            labelSenha.Location = new Point(30, 80);
            labelSenha.Text = "Senha:";
            labelSenha.BackColor = Color.Transparent;
            cardLogin.Controls.Add(labelSenha);

            campoSenha = new TextBox();

            campoSenha.Location = new Point(130, 80);
            campoSenha.PasswordChar = '*';
            cardLogin.Controls.Add(campoSenha);

            botaoLogin = new BotaoArredondado();

            botaoLogin.Location = new Point(120, 120);
            botaoLogin.Text = "Entrar";
            cardLogin.Controls.Add(botaoLogin);

            // Adição dos controles ao formulário
            this.Controls.Add(cardLogin);
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Atualiza o location do panel quando o tamanho da janela é alterado
            cardLogin.Location = new Point(
                (this.ClientSize.Width - cardLogin.Width) / 2,
                (this.ClientSize.Height - cardLogin.Height) / 2
            );

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath panelPath = new GraphicsPath();
            Rectangle rect = cardLogin.ClientRectangle;
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
            cardLogin.Region = new Region(panelPath);
        }


        #endregion
    }
}

