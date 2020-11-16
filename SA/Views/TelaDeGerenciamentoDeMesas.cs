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
        }

        private void voltar(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }

        private void carregarInformacoes()
        {
            var statusPedido = comboBoxStatusPedido.Text;
            var numMesa = int.Parse.ToString(comboBoxNumMesa.Text);
            var statusMesa = comboBoxStatus.Text;

            using (var context = new churrascariaContext())
            {
                var infoPedido = from ip in context.Pedidos
                                  where ip.Status == statusPedido
                                  select ip;

                var infoMesa = from im in context.Mesas
                                 where im.Status == statusMesa
                                 && im.Id == numMesa
                                 select im;

                var obs = from o in context.Mesas
                         select new {o.Observacao};

                textBoxObservacao.Text = obs.ToString();

                if (infoMesa.FirstOrDefault() != null)
                {
                    Mesas nMesa = (Mesas)infoMesa.FirstOrDefault();
                    if (nMesa.Id == 1)
                    {

                    }
                }
            }
        }

        private void editar(object sender, EventArgs e)
        {
            
        }
    }
}
