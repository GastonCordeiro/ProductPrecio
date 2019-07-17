using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductPrecio
{
    public partial class Form1 : Form
    {
        ProductPrecio.Producto ListaPrecio = new ProductPrecio.Producto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               ListaPrecio.CargarLista(
                    txtProducto.Text, 
                    txtPrecio.Text);
               label1.Text = ListaPrecio.Listado();
                
            }
            catch (Exception er)
            {
                MessageBox.Show("Error:Este Producto ya fue cargado.\r\n " + er.Message);
            }
        }

        private void btnAlfabeto_Click(object sender, EventArgs e)
        {
           // label1.Text = ListaPrecio.ordenaralfa();
        }
    }
}
