using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class TelaDeCadastroDeMesas : Form
    {
        public TelaDeCadastroDeMesas()
        {
            InitializeComponent();
            buttonSalvar.Click += salvar;
        }

        private void salvar(object sender, EventArgs e)
        {
            Mesas cadMesa = new Mesas();
            cadMesa.Numero = int.Parse(textBoxNumero.Text);
            cadMesa.Nomemesa = textBoxNomeMesa.Text;
            cadMesa.Observacao = textBoxObservacao.Text;
            cadMesa.Status = comboBoxStatus.SelectedItem.ToString();

            using (var context = new ChurrascariaContext())
            {
                context.Mesas.Add(cadMesa);
                context.SaveChanges();
                MessageBox.Show("Salvo com Sucesso!");
            }
        }
    }
}
