using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

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
            var nome = textBoxNome1.Text;
            var senha = textBoxSenha1.Text;

            using (var context = new ChurrascariaContext())
            {
                var funcionario = from f in context.Cadastro
                                  where f.Nome == nome
                                  && f.Senha == senha
                                  select f;
                if (funcionario != null)
                {
                    MessageBox.Show("Login efetuado com sucesso!");
                    new TelaDeInicio().Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login inválido \nFavor tentar novamente, ou clicar no botão 'cadastrar' para poder se cadastrar.");
                }
            }
        }

        private void telaCadastrar(object sender, EventArgs e)
        {
            new TelaDeCadastramentoFuncionários().Show();
            this.Visible = false;
        }
    }
}
