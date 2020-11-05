using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SA.Models;

namespace SA.Views
{
    public partial class TelaDeCadastramentoFuncionários : Form
    {
        public TelaDeCadastramentoFuncionários()
        {
            InitializeComponent();
            buttonSalvarCadastro.Click += salvar;
        }

        private void salvar(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Nome = textBoxNome2.Text;
            cad.Senha = int.Parse(textBoxSenha2.Text);
        }
    }
}
