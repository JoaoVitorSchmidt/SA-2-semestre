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
    public partial class TelaDeCadastramentoDePedidos : Form
    {
        List<Itenspedido> itens = new List<Itenspedido>();
        public TelaDeCadastramentoDePedidos()
        {
            InitializeComponent();
            carregarBebidas();
            buttonFundo.Enabled = false;
            buttonFecharPedido.Click += fecharPedido;
            buttonAddAoPedido.Click += adiocionarAoPedido;
        }

        private void adiocionarAoPedido(object sender, EventArgs e)
        {
            Produtos selecionado = (Produtos)comboBoxProdutos.SelectedItem;
            itens.Add(new Itenspedido()
            {
                IdProduto = selecionado.Id,
                Quantidade = int.Parse(textBoxQuant.Text),
                ValorProduto = selecionado.Valor
            });

            List<Itensdto> itensPedido = new List<Itensdto>();
            itens.ForEach(i =>
            {
                using (var context = new churrascariaContext())
                {
                    var item = from prod in context.Produtos
                               where prod.Id == i.IdProduto
                               select new Itensdto { Nome = prod.Nome, Quantidade = int.Parse(i.Quantidade.ToString()) };

                    itensPedido.Add((Itensdto)item.SingleOrDefault());
                }
            });

            dataGridViewProdutosPedido.DataSource = itensPedido;
        }

        private void carregarBebidas()
        {
            using (var context = new churrascariaContext())
            {
                var produtos = from prod in context.Produtos
                               select new Produtos
                               {
                                   Id = prod.Id,
                                   Nome = prod.Nome,
                                   Valor = prod.Valor
                               };

                comboBoxProdutos.DataSource = produtos.ToList();
            }
        }

        private void fecharPedido(object sender, EventArgs e)
        {
            Pedidos novo = new Pedidos()
            {
                Datapedido = DateTime.Now
            };

            using (var context = new churrascariaContext())
            {
                context.Pedidos.Add(novo);
                context.SaveChanges();

                itens.ForEach(i =>
                {
                    i.IdPedido = novo.Id;
                    context.Itenspedido.Add(i);
                });

                context.SaveChanges();

                new TelaDePanoramaDasMesas().Show();
                this.Visible = false;
            }
        }
    }
}
