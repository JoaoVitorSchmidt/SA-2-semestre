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
    public partial class TelaDePanoramaDasMesas : Form
    {
        Pedidos p = new Pedidos();
        Mesas m = new Mesas();

        int mesa;
        string statPedido;
        string statMesa;
        string observacao;

        public TelaDePanoramaDasMesas()
        {
            InitializeComponent();
            InformacoesSituacaoMesa();
            buttonFundo.Enabled = false;
        }

        private void InformacoesSituacaoMesa()
        {
            mesa = m.Id;

            if (mesa == 2)
            {
            }

            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa.ToString(), statMesa, statPedido, observacao);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonGerenciamentoDasMesas_Click(object sender, EventArgs e)
        {
            new TelaDeGerenciamentoDeMesas().Show();
            this.Visible = false;
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            new TelaDeInicioAtendente().Show();
            this.Visible = false;
        }

        private void buttonMesa1_Click(object sender, EventArgs e)
        {
            m.Id = 1;
            InformacoesSituacaoMesa();
        }
        private void buttonMesa2_Click(object sender, EventArgs e)
        {
            m.Id = 2;
            InformacoesSituacaoMesa();
        }

        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa4_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa5_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa6_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa7_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa8_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa9_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa10_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa11_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }

        private void buttonMesa12_Click(object sender, EventArgs e)
        {
            InformacoesSituacaoMesa();
        }
    }
}