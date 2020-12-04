﻿using System;
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
            //Botões da Tela de Cadastramento
            InitializeComponent();
            buttonSalvarCadastro.Click += salvar;
            buttonVoltar.Click += ButtonVoltar_Click;
        }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            //Voltando para a tela de início
            new TelaDeLogin().Show();
            this.Visible = false;
        }

        //Esse metódo vai salvar as informações cadastradas no banco de dados.
        private void salvar(object sender, EventArgs e)
        {
            //Salvando as informações das variáveis
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

            using (var context = new churrascariaContext())
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
