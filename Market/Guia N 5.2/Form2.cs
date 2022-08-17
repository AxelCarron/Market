using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_N_5._2
{
    public partial class Form2 : Form
    {
        double Monto, Vuelto, Total = 0;
        List <string> Productos = new List<string>();
        public Form2(double pTotal, string pProductos )
        {
            InitializeComponent();
            lblTotal1.Text = Convert.ToString("Total: " + Math.Round(pTotal));
            Total = pTotal;
            Productos = pProductos;


        }       
        
        private void button1_Click(object sender, EventArgs e)
        {

            Monto = Convert.ToDouble(txtEfectivo.Text);

            Vuelto = Monto - Total;

            lblTicket.Text = ("Reseumen de compra" + "\n Producto: " + Productos );
            

            
            

            //if (Monto < Total)
            //{
            //    lstTicket.Items.Add("Monto insuficiente");

            //}
            
        }
    }
}
