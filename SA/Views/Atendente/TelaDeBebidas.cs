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
    public partial class TelaDeBebidas : Form
    {
        public TelaDeBebidas()
        {
            InitializeComponent();
            buttonFecharPedido.Click += bebidasSelecionadas;
        }

        private void bebidasSelecionadas(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxBebidas.CheckedItems)
            {
                Pedidos bebidas = new Pedidos();
                bebidas.Itenspedido = bebidas.Itenspedido + checkedListBoxBebidas.CheckedItems.ToString() + ", ";

                using (var context = new churrascariaContext())
                {
                    context.Pedidos.Add(bebidas);
                    context.SaveChanges();
                }
            }
        }
    }
}
