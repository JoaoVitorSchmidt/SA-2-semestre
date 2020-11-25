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
    public partial class TelaDeGerenciamentoDeMesas : Form
    {
        public TelaDeGerenciamentoDeMesas()
        {
            InitializeComponent();
            carregarInformacoes();
            buttonFundo.Enabled = false;
            buttonEditar.Click += editar;
            buttonVoltar.Click += voltar;
            comboBoxNumMesa.TextChanged += informacoes;
        }

        private void informacoes(object sender, EventArgs e)
        {
            Mesas selecionado = (Mesas)comboBoxNumMesa.SelectedItem;
            textBoxObservacao.Text = selecionado.Observacao;
            comboBoxStatus.Text = selecionado.Status;
        }

        private void voltar(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }

        private void carregarInformacoes()
        {
            Mesas mesaSelecionada = (Mesas)comboBoxNumMesa.SelectedItem;

            using (var context = new churrascariaContext())
            {
                var mesas = from m in context.Mesas
                            where m.Id == mesaSelecionada.Id
                            select new Mesas {Id = m.Id, Nomemesa = m.Nomemesa, Observacao = m.Observacao, Status = m.Status };

                comboBoxNumMesa.DataSource = mesas.ToList();
                comboBoxStatus.DataSource = mesas.ToList();
            }
        }

        private void editar(object sender, EventArgs e)
        {
            Mesas selecionada = (Mesas)comboBoxNumMesa.SelectedItem;
            selecionada.Status = comboBoxStatus.Text;
            selecionada.Observacao = textBoxObservacao.Text;

            Pedidos selecionado = (Pedidos)comboBoxStatusPedido.SelectedItem;
            selecionado.Status = comboBoxStatusPedido.Text;

            using (var context = new churrascariaContext())
            {
                context.Update(selecionada);
                context.Update(selecionado);
                context.SaveChanges();
            }
        }
    }
}
