
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
        private RoundedTextBox campoUsuario;
        private RoundedTextBox campoSenha;
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
            cardLogin.BackColor =Theme.WHITE;
            cardLogin.Location = new Point(20, 20);
            cardLogin.Size = new Size(300, 200);
            cardLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            cardLogin.Dock = DockStyle.None;
            cardLogin.MinimumSize = new Size(300, 300);
            cardLogin.MaximumSize = new Size(500, 500);
            cardLogin.Location = new Point((this.ClientSize.Width - cardLogin.Width) / 2, (this.ClientSize.Height - cardLogin.Height) / 2);

            campoUsuario = new RoundedTextBox("Usuario:", 200, 30);

            campoUsuario.Location = new Point(20, 110);
            campoUsuario.MinimumSize = new Size(100, 0);
            campoUsuario.MaximumSize = new Size(200, 0);
            campoUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            cardLogin.Controls.Add(campoUsuario);


            campoSenha = new RoundedTextBox("Senha:", 200, 30);

            campoSenha.Location = new Point(20, 80);
            cardLogin.Controls.Add(campoSenha);

            botaoLogin = new BotaoArredondado();

            botaoLogin.Location = new Point((cardLogin.Height-botaoLogin.Width)/2, cardLogin.Height-100);
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


        #endregion
    }
}

