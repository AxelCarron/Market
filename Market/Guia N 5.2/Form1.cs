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
    public partial class Form1 : Form
    {
        double Manzana = 30.5;
        double Dulcedeleche = 55.8;
        double Oreo = 35.6;
        double Shampoo = 40.6;
        double Harina = 20.6;
        double Fideos = 25.2;
        double Porcentaje = 0;
        double resultado;
        double Cantidad = 0;
        double Total = 0;
        List<double> productos = new List<double>();
        public Form1()

        {
            InitializeComponent();
            
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
           
            Cantidad = Convert.ToDouble(txtCantidad.Text);
            if (chkManzana.Checked)
            {

                Calcular(Manzana, Cantidad, Porcentaje, resultado);
                lstProductos.Items.Add("Manzana ($30,5)" + " - " + Math.Round(resultado));
                total(resultado);
                productos.Add(resultado);


            }
            


            if (chkDulcedeleche.Checked)
            {

                Calcular(Dulcedeleche, Cantidad, Porcentaje, resultado);
                lstProductos.Items.Add("Dulce de leche ($55,8)" + " - " + Math.Round(resultado));
                total(resultado);
                productos.Add(resultado);

            }
            

            if (chkOreo.Checked)
            {

                Calcular(Oreo, Cantidad, Porcentaje, resultado);
                lstProductos.Items.Add("Oreo ($35,6)" + " - " + Math.Round(resultado));
                total(resultado);
                productos.Add(resultado);

            }
            

            if (chkShampoo.Checked)
            {

                Calcular(Shampoo, Cantidad, Porcentaje, resultado);
                lstProductos.Items.Add("Shampoo ($40,6)" + " - " + Math.Round(resultado));
                total(resultado);
                productos.Add(resultado);

            }

           

            if (chkHarina.Checked)
            {

                Calcular(Harina, Cantidad, Porcentaje, resultado);
                lstProductos.Items.Add("Harina ($20,6)" + " - " + Math.Round(resultado));
                total(resultado);
                productos.Add(resultado);


            }
            

            if (chkFideos.Checked)
            {

                Calcular(Fideos, Cantidad, Porcentaje, resultado);
                lstProductos.Items.Add("Fideos($25,2)" + " - " + Math.Round(resultado));
                total(resultado);
                productos.Add(resultado);
            }
           


            lblTotal.Text = ("Total: " + Math.Round(Total));
            

            Form2 Form2 = new Form2(Total,Convert.ToString(productos));
            Form2.ShowDialog();

        }
        private void Calcular(double Producto, double Can, double Por, double Res)
        {
            Producto = Producto * Can;
            Por = Producto * 30 / 100;
            resultado = Por + Producto;

        }

        private void total (double resultado)
        {
            Total = resultado + Total;

        }
    }
}
