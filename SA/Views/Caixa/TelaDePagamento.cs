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
    public partial class TelaDePagamento : Form
    {
        public TelaDePagamento()
        {
            InitializeComponent();
            carregarInformacoes();
            dataGridViewPedidosPagamento.CellClick += mostrarId;
            buttonPagar.Click += pagar;
            buttonSignOut.Click += signOut;
        }

        //Esse método carrega a id do pedido na text box id, pra que se possa realizar o pagamento.
        private void mostrarId(object sender, DataGridViewCellEventArgs e)
        {
            Itenspedido selecionado = (Itenspedido)dataGridViewPedidosPagamento.CurrentRow.DataBoundItem;
            textBoxId.Text = selecionado.IdPedido.ToString();
        }

        //Este método vai carregar as informações do dataGridView.
        private void carregarInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var pedidos = from p in context.Itenspedido
                              select new Itenspedido { IdPedido = p.IdPedido, IdProduto = p.IdProduto, ValorProduto = p.ValorProduto, Quantidade = p.Quantidade, Total = p.Total};

                dataGridViewPedidosPagamento.DataSource = pedidos.ToList();
            }
        }

        //Este método vai ao ser clicado, realizar o logout, levando o funcionário de volta a tela de login.
        private void signOut(object sender, EventArgs e)
        {
            new TelaDeLogin().Show();
            this.Visible = false;
        }

        //Esse método vai excluir o pedido do banco de dados ao se realizar o pagamento.
        private void pagar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realizar o pagamento deste pedido?", "Pagamento de pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Itenspedido excluir = (Itenspedido)dataGridViewPedidosPagamento.CurrentRow.DataBoundItem;
                excluir.IdPedido = int.Parse(textBoxId.Text);

                using (var context = new churrascariaContext())
                {
                    context.Remove(excluir);
                    context.SaveChanges();

                    var pedidos = from p in context.Itenspedido
                                  select p;

                    dataGridViewPedidosPagamento.DataSource = pedidos.ToList();
                }
            }
        }
    }
}
