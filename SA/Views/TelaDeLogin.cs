﻿using SA.Models;
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
            buttonEntrar.Click += entrar;
            buttonTelaCadastrar.Click += telaCadastrar;
        }

        private void entrar(object sender, EventArgs e)
        {
            Cadastro c = new Cadastro();
            c.Nome = textBoxNome1.Text;
            c.Senha = int.Parse(textBoxSenha1.Text);
            if (c.Nome == "admin" && c.Senha == 123)
            {
                MessageBox.Show("Login efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Login inválido \nFavor tentar novamente, ou clicar no botão 'cadastrar' para poder se cadastrar.");
            }
        }

        private void telaCadastrar(object sender, EventArgs e)
        {
            new TelaDeCadastramento().Show();
            this.Visible = false;
        }
    }
}
