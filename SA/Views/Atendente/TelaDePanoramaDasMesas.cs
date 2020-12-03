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
        public TelaDePanoramaDasMesas()
        {
            InitializeComponent();
            buttonFundo.Enabled = false;
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
            string mesa = "1";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }
        private void buttonMesa2_Click(object sender, EventArgs e)
        {
            string mesa = "2";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa3_Click(object sender, EventArgs e)
        {
            string mesa = "3";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa4_Click(object sender, EventArgs e)
        {
            string mesa = "4";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa5_Click(object sender, EventArgs e)
        {
            string mesa = "5";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa6_Click(object sender, EventArgs e)
        {
            string mesa = "6";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa7_Click(object sender, EventArgs e)
        {
            string mesa = "7";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa8_Click(object sender, EventArgs e)
        {
            string mesa = "8";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa9_Click(object sender, EventArgs e)
        {
            string mesa = "9";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa10_Click(object sender, EventArgs e)
        {
            string mesa = "10";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }

        private void buttonMesa11_Click(object sender, EventArgs e)
        {
            string mesa = "11";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }
        private void buttonMesa12_Click(object sender, EventArgs e)
        {
            string mesa = "12";
            Situação_da_Mesa Inf = new Situação_da_Mesa(mesa);
            Inf.Show();
            this.Visible = false;
        }
    }
}