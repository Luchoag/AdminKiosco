using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKiosco
{
    public partial class Form5 : Form
    {

        SQLQueries consulta = new SQLQueries();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Tab1
            consulta.cargarComboProd(comboProd);
            consulta.cargarComboProv(comboProv);
            consulta.selectComboProvIndex(comboProv, comboProd);
            txtNombreProd.Text = comboProd.SelectedItem.ToString();
            txtPrecioProd.Text = consulta.getPrecio(comboProd).ToString();
            //Tab2
            consulta.cargarComboProv(comboProvTab2);
            comboProvTab2.SelectedIndex = 0;
            consulta.getProveedorData(comboProvTab2.SelectedItem.ToString(), txtNombreProv, txtCUIL, txtDomic, txtTel);
            //Tab3
            consulta.cargarComboFecha(comboFecha);
            comboFecha.SelectedIndex = 0;
            consulta.cargarComboProdTab3(comboFecha.SelectedItem.ToString(), comboProdTab3);
            comboProdTab3.SelectedIndex = 0;
            consulta.getVentasData(comboFecha.SelectedItem.ToString(), consulta.getIdProducto(comboProdTab3.SelectedItem.ToString()), txtIngreso, txtVendido);
        }

        private void comboProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreProd.Text = comboProd.SelectedItem.ToString();
            txtPrecioProd.Text = consulta.getPrecio(comboProd).ToString();
            consulta.selectComboProvIndex(comboProv, comboProd);
            
        }

        private void btnAplicarProd_Click(object sender, EventArgs e)
        {
            if (checkPrecio()) {
                float fPrecio = float.Parse(txtPrecioProd.Text);
                consulta.updateProducts(comboProd.SelectedItem.ToString(), txtNombreProd.Text, fPrecio, consulta.getIdProveedor(comboProv.Text));
                labelPrecioError.Visible = false;
            }
        }

        private bool checkPrecio()
        {
            float f;
            bool precio = float.TryParse(txtPrecioProd.Text, out f);
            if (!precio) labelPrecioError.Visible = true;
            else labelPrecioError.Visible = false;
            return precio;
        }

        private void comboProvTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.getProveedorData(comboProvTab2.SelectedItem.ToString(), txtNombreProv, txtCUIL, txtDomic, txtTel);
        }

        private void btnAplicarProv_Click(object sender, EventArgs e)
        {
            consulta.updateProveedores(comboProvTab2.SelectedItem.ToString(), txtNombreProv.Text, txtCUIL.Text, txtDomic.Text, txtTel.Text);
        }

        private void comboProdTab3_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.getVentasData(comboFecha.SelectedItem.ToString(), consulta.getIdProducto(comboProdTab3.SelectedItem.ToString()), txtIngreso, txtVendido);
        }

        private void comboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.cargarComboProdTab3(comboFecha.SelectedItem.ToString(), comboProdTab3);
            comboProdTab3.SelectedIndex = 0;
            consulta.getVentasData(comboFecha.SelectedItem.ToString(), consulta.getIdProducto(comboProdTab3.SelectedItem.ToString()), txtIngreso, txtVendido);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNumbers(txtIngreso) && checkNumbers(txtVendido))
            consulta.updateVentas(comboFecha.SelectedItem.ToString(), consulta.getIdProducto(comboProdTab3.SelectedItem.ToString()), Convert.ToInt32(txtIngreso.Text), Convert.ToInt32(txtVendido.Text));
        }

        private bool checkNumbers(TextBox txt)
        {
            int i;
            bool number = int.TryParse(txt.Text, out i);
            Point controlLoc = this.PointToScreen(txt.Location);
            lblIngrError.Location = new Point(224, controlLoc.Y - this.Location.Y - 4);
            if (!number)
            {
                lblIngrError.Visible = true;
            }
            else lblIngrError.Visible = false;
            return number;
        }
   }
}
