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
            carregarInformacoesMesa();
            buttonFundo.Enabled = false;
            buttonEditar.Click += editar;
            buttonVoltar.Click += voltar;
            comboBoxNumMesa.TextChanged += informacoesMesa;
        }
        private void informacoesMesa(object sender, EventArgs e)
        {
            Mesas selecionada = (Mesas)comboBoxNumMesa.SelectedItem;
            comboBoxStatus.Text = selecionada.Statusmesa;
            comboBoxStatusPedido.Text = selecionada.Statuspedido;
            textBoxObservacao.Text = selecionada.Observacao;
        }

        private void voltar(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }

        private void carregarInformacoesMesa()
        {
            using (var context = new churrascariaContext())
            {
                var mesas = from m in context.Mesas
                              select m;

                comboBoxNumMesa.DataSource = mesas.ToList();
            }
        }

        private void editar(object sender, EventArgs e)
        {
            Mesas selecionada = (Mesas)comboBoxNumMesa.SelectedItem;
            selecionada.Statusmesa = comboBoxStatus.Text;
            selecionada.Statuspedido = comboBoxStatusPedido.Text;
            selecionada.Observacao = textBoxObservacao.Text;

            using (var context = new churrascariaContext())
            {
                context.Update(selecionada);
                context.SaveChanges();
            }
        }
    }
}
