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
        private int mostrarID;

        public TelaDePagamento()
        {
            InitializeComponent();
            carregarInformacoes();
            dataGridViewPedidosPagamento.CellClick += mostrarId;
            buttonPagar.Click += pagar;
            buttonSignOut.Click += signOut;
        }

        private void mostrarId(object sender, DataGridViewCellEventArgs e)
        {
            Pedidos selecionado = (Pedidos)dataGridViewPedidosPagamento.CurrentRow.DataBoundItem;
            textBoxId.Text = selecionado.Id.ToString();
        }

        //Este método vai carregar as informações do dataGridView.
        private void carregarInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var pedidos = from p in context.Pedidos
                              select p;

                dataGridViewPedidosPagamento.DataSource = pedidos.ToList();
            }
        }

        //Este método vai ao ser clicado, realizar o logout, levando o funcionário de volta a tela de login.
        private void signOut(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Esse método vai excluir o pedido do banco de dados ao se realizar o pagamento.
        private void pagar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realizar o pagamento deste pedido?", "Pagamento de pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Pedidos excluir = (Pedidos)dataGridViewPedidosPagamento.CurrentRow.DataBoundItem;
                excluir.Id = int.Parse(textBoxId.Text);

                using (var context = new churrascariaContext())
                {
                    context.Remove(excluir);
                    context.SaveChanges();

                    var pedidos = from p in context.Pedidos
                                  select p;

                    dataGridViewPedidosPagamento.DataSource = pedidos.ToList();
                }
            }
        }
    }
}
