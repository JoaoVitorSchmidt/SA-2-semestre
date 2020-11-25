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
        }
        public Situação_da_Mesa(string mesa)
        {
            InitializeComponent();
            nmrMesaTXT.Text = mesa;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }
    }
}
