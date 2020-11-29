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

            if (statsPedidoTxt.Text == "Esperando Atendente")
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
    }
}
