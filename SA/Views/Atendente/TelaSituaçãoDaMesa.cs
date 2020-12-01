using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SA.Models;
using System.Linq;

namespace SA.Views
{
    public partial class Situação_da_Mesa : Form
    {
        public Situação_da_Mesa()
        {
            InitializeComponent();
            
        }
        public Situação_da_Mesa(string mesa)
        {
            InitializeComponent();
            string id = mesa;
            int nmr = int.Parse(id);
            carregarInformacoes(nmr);
            nmrMesaTXT.Text = mesa;
                    
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new TelaDePanoramaDasMesas().Show();
            this.Visible = false;
        }
        private void carregarInformacoes(int mesa)
        {
            using (var context = new churrascariaContext())
            {
                var statusmesa = from e in context.Mesas
                                 where e.Id == mesa
                                 select new Mesas {Status = e.Status };
                statsMesaTxt.Text = statusmesa.ToString();
            }
            using (var context = new churrascariaContext())
            {
                var statusped = from e in context.Pedidos
                                 where e.Id == mesa
                                 select new Mesas { Status = e.Status };
                statsPedidoTxt.Text = statusped.ToString();
            }
            using (var context = new churrascariaContext())
            {
                var obsmesa = from e in context.Mesas
                                 where e.Id == mesa
                                 select new Mesas { Observacao = e.Observacao };
                observacaoTxt.Text = obsmesa.ToString();
            }
        }       
    }
}
