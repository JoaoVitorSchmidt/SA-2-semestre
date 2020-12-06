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
            buttonVoltar.Click += voltar;
        }

        //Esse método ao o botão voltar ser clicado, o mesmo vai retornar o usuário para a tela panorama de mesas.
        private void voltar(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }

        //Esse método vai, ao o botão adicionar ser clicado, o mesmo vai adionar o produto ao datagridview, e ao pedido final.
        private void adiocionarAoPedido(object sender, EventArgs e)
        {
            Produtos selecionado = (Produtos)comboBoxProdutos.SelectedItem;
            itens.Add(new Itenspedido()
            {
                IdProduto = selecionado.Id,
                Quantidade = int.Parse(textBoxQuant.Text),
                ValorProduto = selecionado.Valor
            });

            List<dynamic> itensPedido = new List<dynamic>();
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

        //Esse método vai carregar as informações na comboBox produtos.
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

        //Esse método vai ao o botão fechar pedido ser clicado, adicionar as informações necessárias no banco de dados.
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

                    Produtos p = context.Find<Produtos>(i.IdProduto);

                    context.Update(p);
                });

                context.SaveChanges();

                MessageBox.Show("Pedido efetuado com sucesso!");

                new TelaDePanoramaDasMesas().Show();
                this.Visible = false;
            }
        }
    }
}
