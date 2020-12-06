using SA.Views.Cozinheiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeInicioCozinheiro : Form
    {
        public TelaDeInicioCozinheiro()
        {
            InitializeComponent();
            btnPedidos.Click += BtnPedidos_Click;
            btnEstoque.Click += BtnEstoque_Click;
            btnSignOut.Click += BtnSignOut_Click;
        }

        //Esse método vai ao o botão sign out ser clicado, levar o usuário para a tela de login.
        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            new TelaDeLogin().Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão estoque ser clicado, levar o usuário para a tela de estoque.
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão pedidos ser clicado, levar o usuário para a tela de pedidos.
        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            new TelaPedidos().Show();
            this.Visible = false;
        }
    }
}
