using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeCardapio : Form
    {
        public TelaDeCardapio()
        {
            InitializeComponent();
            buttonEspClassico.Click += EspetoClassico;
            buttonEspEspecial.Click += EspetoEspecial;
        }

        private void EspetoEspecial(object sender, EventArgs e)
        {
            
        }

        private void EspetoClassico(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
