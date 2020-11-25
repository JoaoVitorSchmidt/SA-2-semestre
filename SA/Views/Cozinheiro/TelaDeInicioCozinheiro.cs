using SA.Views.Cozinheiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeInicioCozinheiro : Form
    {
        public TelaDeInicioCozinheiro()
        {
            InitializeComponent();
            btnPedidos.Click += BtnPedidos_Click;
            btnEstoque.Click += BtnEstoque_Click;
            btnSignOut.Click += BtnSignOut_Click;
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            new TelaDeLogin().Show();
            this.Visible = false;
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            new TelaEstoque().Show();
            this.Visible = false;
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            new TelaPedidos().Show();
            this.Visible = false;
        }
    }
}
