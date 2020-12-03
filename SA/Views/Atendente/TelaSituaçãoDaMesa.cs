using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class Situação_da_Mesa : Form
    {
        public Situação_da_Mesa()
        {
            InitializeComponent();
            buttonFundo.Enabled = false;
            buttonFazerPedido.Visible = false;

            if (statsPedidoTxt.Text != "Esperando Atendente")
            {
                buttonFazerPedido.Visible = false;
            }
            else
            {
                buttonFazerPedido.Visible = true;
            }
        }
        public Situação_da_Mesa(string mesa, string statMesa, string statPedido, string observacao)
        {
            InitializeComponent();
            nmrMesaTXT.Text = mesa;
            observacaoTxt.Text = observacao;
            statsMesaTxt.Text = statMesa;
            statsPedidoTxt.Text = statPedido;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }
<<<<<<< HEAD
=======
        private void carregarInformacoes(int mesa)
        {
            using (var context = new churrascariaContext())
            {
                var statusmesa = from e in context.Mesas
                                 where e.Id == mesa
                                 select new Mesas {Statusmesa = e.Statusmesa };
                statsMesaTxt.Text = statusmesa.ToString();
            }
            using (var context = new churrascariaContext())
            {
                var statusped = from e in context.Mesas
                                 where e.Id == mesa
                                 select new Mesas { Statuspedido = e.Statuspedido };
                statsPedidoTxt.Text = statusped.ToString();
            }
            using (var context = new churrascariaContext())
            {
                var obsmesa = from e in context.Mesas
                                 where e.Id == mesa
                                 select new Mesas { Observacao = e.Observacao };
                observacaoTxt.Text = obsmesa.ToString();
            }
        }       
>>>>>>> 7feaeaa307ec36199ca005d18561f2093fd6719f
    }
}
