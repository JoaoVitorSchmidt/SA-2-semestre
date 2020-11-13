using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaGerenciamentoDeMesas : Form
    {
        public TelaGerenciamentoDeMesas()
        {
            InitializeComponent();
            carregaMesas();
            buttonFundo.Enabled = false;
            buttonEditar.Click += editar;
            buttonInicio.Click += telaDeInicio;
        }
        private void carregaMesas()
        {
            Mesas mesaSelecionada = (Mesas)comboBoxNMesa.SelectedItem;

            using (var context = new ChurrascariaContext())
            {
                var mesa = from m in context.Mesas
                           where m.Numero == mesaSelecionada.Numero
                           select new {m.Numero, m.Nomemesa , m.Observacao, m.Status };

            }
        }

        private void telaDeInicio(object sender, EventArgs e)
        {
            new TelaDeInicioAtendente().Show();
            this.Visible = false;
        }

        private void editar(object sender, EventArgs e)
        {
            
        }
    }
}
