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

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
            this.Visible = false;
        }

        private void BtnTelaInicio_Click(object sender, EventArgs e)
        {
            new TelaDeInicioCozinheiro().Show();
            this.Visible = false;
        }

        private void carregaInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var pedidos = from p in context.Itenspedido
                              select p;

                dataGridViewPedidos.DataSource = pedidos.ToList();
            }
        }
    }
}
