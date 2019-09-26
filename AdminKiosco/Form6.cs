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
    public partial class Form6 : Form
    {

        SQLQueries consulta = new SQLQueries();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //Tab1
            consulta.cargarComboProd(comboProd);
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
        }

        private void comboProvTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.getProveedorData(comboProvTab2.SelectedItem.ToString(), txtNombreProv, txtCUIL, txtDomic, txtTel);
        }

        private void comboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.cargarComboProdTab3(comboFecha.SelectedItem.ToString(), comboProdTab3);
            comboProdTab3.SelectedIndex = 0;
            consulta.getVentasData(comboFecha.SelectedItem.ToString(), consulta.getIdProducto(comboProdTab3.SelectedItem.ToString()), txtIngreso, txtVendido);
        }

        private void comboProdTab3_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.getVentasData(comboFecha.SelectedItem.ToString(), consulta.getIdProducto(comboProdTab3.SelectedItem.ToString()), txtIngreso, txtVendido);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta.deleteVentas(comboFecha.SelectedItem.ToString(), comboProdTab3.SelectedItem.ToString());
        }

        private void btnAplicarProd_Click(object sender, EventArgs e)
        {
            consulta.deleteProducts(comboProd.SelectedItem.ToString());
        }

        private void btnAplicarProv_Click(object sender, EventArgs e)
        {
            consulta.deleteProveedor(comboProvTab2.SelectedItem.ToString());
        }
    }
}
