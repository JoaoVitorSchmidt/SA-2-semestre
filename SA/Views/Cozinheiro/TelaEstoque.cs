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
        }

        //Metódo para adicionar informações ao banco de dados, ao clicar o buttonAdicinar.
        private void adicionar(object sender, EventArgs e)
        {
            Estoque es = new Estoque();
            es.Identificacao = textBoxIdentificacao.Text;
            es.QuantidadeKg = decimal.Parse(textBoxQuantidadeKg.Text);
            es.ValorKg = decimal.Parse(textBoxValorUnit.Text);
        }

        //Metódo para mostrar as informações nas textBoxs, ao clicar em um certo registro.
        private void mostrarInformacoes(object sender, EventArgs e)
        {
            Estoque selecionado = (Estoque)dataGridViewEstoque.CurrentRow.DataBoundItem;
            textBoxIdentificacao.Text = selecionado.Identificacao;
            textBoxQuantidadeKg.Text = selecionado.QuantidadeKg.ToString();
            textBoxValorUnit.Text = selecionado.ValorKg.ToString();
        }

        //Metódo para salvar as informações editadas.
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
        }

        //Metódo para carregar as infomações do banco de dados no dataGridView.
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
