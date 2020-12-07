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
            int idPedido = int.Parse(dataGridViewPedidosPagamento.CurrentRow.Cells[0].Value.ToString());

            using (var context = new churrascariaContext())
            {
                Pedidos selecionado = context.Pedidos.Find(idPedido);
                textBoxId.Text = selecionado.Id.ToString();
            }

        }

        //Este método vai carregar as informações do dataGridView.
        private void carregarInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var pedidos = from p in context.Pedidos
                              join ped in context.Itenspedido on p.Id equals ped.IdPedido
                              select new { Pedido = ped.IdPedido,  Produtos = ped.IdProduto, Pago = p.Pago, ValorProduto = ped.ValorProduto, Quantidade = ped.Quantidade, Total = ped.Total };
                
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
                int idPedido = int.Parse(dataGridViewPedidosPagamento.CurrentRow.Cells[0].Value.ToString());

                using (var context = new churrascariaContext())
                {
                    Pedidos pagar = context.Pedidos.Find(idPedido);
                    pagar.Id = int.Parse(textBoxId.Text);
                    pagar.Pago = 1;

                    context.SaveChanges();

                    var pedidos = from p in context.Pedidos
                                  join ped in context.Itenspedido on p.Id equals ped.IdPedido
                                  select new { Pedido = ped.IdPedido, Produtos = ped.IdProduto, Pago = p.Pago, ValorProduto = ped.ValorProduto, Quantidade = ped.Quantidade, Total = ped.Total };

                    dataGridViewPedidosPagamento.DataSource = pedidos.ToList();
                }
            }
        }
    }
}
