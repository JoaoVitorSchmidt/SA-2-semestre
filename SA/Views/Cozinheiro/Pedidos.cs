using SA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SA.Views.Cozinheiro
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            carregaInformacoes();
        }

        private void carregaInformacoes()
        {
            using (var context = new churrascariaContext())
            {
                var pedidos = from p in context.Pedidos
                              select p;

                dataGridViewPedidos.DataSource = pedidos.ToList();
            }
        }
    }
}
