using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SA.Models;

namespace SA.Views.Cozinheiro
{
    public partial class TelaEstoque : Form
    {
        public TelaEstoque()
        {
            InitializeComponent();
            carregarInformacoes();
            buttonEditar.Click += editar;
            buttonAdicionar.Click += adicionar;
            dataGridViewEstoque.CellClick += mostrarInformacoes;
            btnPedidos.Click += BtnPedidos_Click;
            buttonExcluir.Click += excluir;
        }

        //Este método vai excluir o produto selecionado ao se clicar no botão excluir.
        private void excluir(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este produto do estoque?", "Exclusão do Produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Estoque excluir = (Estoque)dataGridViewEstoque.CurrentRow.DataBoundItem;
                excluir.Identificacao = textBoxIdentificacao.Text;

                using (var context = new churrascariaContext())
                {
                    context.Remove(excluir);
                    context.SaveChanges();

                    var excluirEstoque = from ex in context.Estoque
                                  select ex;

                    dataGridViewEstoque.DataSource = excluirEstoque.ToList();
                }
            }
        }

        //Este método vai fazer com que ao se clicar no botão pedidos, o mesmo abra a tela de Pedidos.
        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            new TelaPedidos().Show();
            this.Visible = false;
        }

        //método para adicionar informações ao banco de dados, ao clicar o buttonAdicinar.
        private void adicionar(object sender, EventArgs e)
        {
            Estoque es = new Estoque();
            es.Identificacao = textBoxIdentificacao.Text;
            es.QuantidadeKg = decimal.Parse(textBoxQuantidadeKg.Text);
            es.ValorKg = decimal.Parse(textBoxValorUnit.Text);

            using (var context = new churrascariaContext())
            {
                context.Estoque.Add(es);
                context.SaveChanges();

                MessageBox.Show("Adicionado com Sucesso!");

                var estoque = from est in context.Estoque
                              select est;

                dataGridViewEstoque.DataSource = estoque.ToList();
            }
        }

        //método para mostrar as informações nas textBoxs, ao clicar em um certo registro.
        private void mostrarInformacoes(object sender, EventArgs e)
        {
            Estoque selecionado = (Estoque)dataGridViewEstoque.CurrentRow.DataBoundItem;
            textBoxIdentificacao.Text = selecionado.Identificacao;
            textBoxQuantidadeKg.Text = selecionado.QuantidadeKg.ToString();
            textBoxValorUnit.Text = selecionado.ValorKg.ToString();
        }

        //método para salvar as informações editadas.
        private void editar(object sender, EventArgs e)
        {
            Estoque editar = (Estoque)dataGridViewEstoque.CurrentRow.DataBoundItem;
            editar.Identificacao = textBoxIdentificacao.Text;
            editar.QuantidadeKg = decimal.Parse(textBoxQuantidadeKg.Text);
            editar.ValorKg = decimal.Parse(textBoxValorUnit.Text);

            using (var context = new churrascariaContext())
            {
                context.Update(editar);
                context.SaveChanges();
            }
            MessageBox.Show("Editado com Sucesso!");
        }

        //método para carregar as infomações do banco de dados no dataGridView.
        private void carregarInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var estoque = from e in context.Estoque
                              select e;

                dataGridViewEstoque.DataSource = estoque.ToList();
            }
        }
    }
}
