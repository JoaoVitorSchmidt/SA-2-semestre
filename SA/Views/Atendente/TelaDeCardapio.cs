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
            Pedidos p = new Pedidos();
            p.Valor = 50;
            p.Itenspedido = "Espeto Corrido Especial";
            p.Status = "Já feito";

            using (var context = new churrascariaContext())
            {
                context.Pedidos.Add(p);
                context.SaveChanges();
            }
            new TelaDeBebidas().Show();
            this.Visible = false;
        }

        private void EspetoClassico(object sender, EventArgs e)
        {
            Pedidos ped = new Pedidos();
            ped.Valor = 35;
            ped.Itenspedido = "Espeto Corrido Clássico";
            ped.Status = "Já feito";

            using (var context = new churrascariaContext())
            {
                context.Pedidos.Add(ped);
                context.SaveChanges();
            }

            new TelaDeBebidas().Show();
            this.Visible = false;
        }
    }
}
