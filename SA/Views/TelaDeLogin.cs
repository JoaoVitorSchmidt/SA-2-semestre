using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
            buttonLogo1.Enabled = false;
            buttonEntrar.Click += entrar;
            buttonTelaCadastrar.Click += telaCadastrar;
        }

        private void entrar(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.Nome = textBoxNome1.Text;
            c.Senha = textBoxSenha1.Text;

            if ((c.Nome == "admin") && (c.Senha == "123") && (c.Nome.Length > 1))
            {
                MessageBox.Show("Login efetuado com sucesso!");
                new TelaGerenciamentoDeMesas().Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login inválido \nFavor tentar novamente, ou clicar no botão 'cadastrar' para poder se cadastrar.");
            }
        }

        private void telaCadastrar(object sender, EventArgs e)
        {
            new TelaDeCadastramentoFuncionários().Show();
            this.Visible = false;
        }
    }
}
