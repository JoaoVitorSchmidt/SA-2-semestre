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
            cad.Senha = textBoxSenha2.Text;
            cad.Cpf = textBoxCPF.Text;
            cad.Cep = textBoxCEP.Text;
            cad.Bairro = textBoxBairro.Text;
            cad.Complemento = textBoxComplemento.Text;
            cad.Cnpj = textBoxCNPJ.Text;
            cad.Cidade = textBoxCidade.Text;
            cad.Numero = int.Parse(textBoxNumero.Text);
            cad.Rua = textBoxRua.Text;
            cad.Telefone = textBoxTelefone.Text;
            cad.Uf = comboBoxUF.SelectedItem.ToString();
            cad.Areatrabalho = comboBoxProfissao2.SelectedItem.ToString();

            using (var context = new ChurrascariaContext())
            {
                context.Cadastro.Add(cad);
                context.SaveChanges();
                MessageBox.Show("Salvo com Sucesso!");
            }
            new TelaDeLogin().Show();
            this.Visible = false;
        }
    }
}
