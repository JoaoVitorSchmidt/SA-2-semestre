using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeInicioAtendente : Form
    {
        public TelaDeInicioAtendente()
        {
            InitializeComponent();
        }

        private void BtnCadPed_Click(object sender, EventArgs e)
        {
            new TelaDeCardapio().Show();
            this.Visible = false;
        }

        private void BtnGerenMesas_Click(object sender, EventArgs e)
        {
            new TelaDeGerenciamentoDeMesas().Show();
            this.Visible = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
