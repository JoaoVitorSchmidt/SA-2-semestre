using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA.Views.Cozinheiro
{
    public partial class TelaPedidos : Form
    {
        public TelaPedidos()
        {
            InitializeComponent();
            carregaInformacoes();
            btnTelaInicio.Click += BtnTelaInicio_Click;
            btnEstoque.Click += BtnEstoque_Click;
        }

        //Esse método vai ao o botão estoque ser clicado, levar o usuário para a tela de estoque.
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
            this.Visible = false;
        }

        //Esse método vai ao o botão tela início ser clicado, levar o usuário para a tela de início do cozinheiro.
        private void BtnTelaInicio_Click(object sender, EventArgs e)
        {
            new TelaDeInicioCozinheiro().Show();
            this.Visible = false;
        }

        //Esse método vai carregar as informações na comboBox pedidos.
        private void carregaInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var pedidos = from p in context.Itenspedido
                              join prod in context.Produtos on p.IdProduto equals prod.Id
                              select new {p.IdPedido, p.IdProduto, prod.Nome, p.Quantidade};

                dataGridViewPedidos.DataSource = pedidos.ToList();
            }
        }
    }
}
