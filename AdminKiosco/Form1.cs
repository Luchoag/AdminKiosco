using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace AdminKiosco
{
    public partial class Form1 : Form
    {
        String orderID;
        String orderProductos;
        String orderPrecio;
        String orderVentas;
        String orderProveedores;
        SqlCommand command;
        SqlDataReader dataReader;
        String sql = "";
        SQLConn conn2 = new SQLConn();
        SQLQueries consulta = new SQLQueries();

        public Form1()
        {
            InitializeComponent();
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.BringToFront();
            this.Activate();
            cargarComboFecha();
            searchProduct("");
            ventaDiaria();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) {
            String query = textBox1.Text;
            searchProduct(query);
        }

        private void searchProduct (String query, String optOrder="") {
            table.Visible = false;
            table.Controls.Clear();
            table.RowStyles.Clear();
            table.RowCount = 1;
            table.Controls.Add(labelID, 0, table.RowCount - 1);
            table.Controls.Add(labelProducto, 1, table.RowCount - 1);
            table.Controls.Add(labelPrecio, 2, table.RowCount - 1);
            table.Controls.Add(labelVenta, 3, table.RowCount - 1);
            table.Controls.Add(labelProveedor, 4, table.RowCount - 1);
            sql = "";
            panel1.Height = table.RowCount * 30;
            sql = @"SELECT Productos.idProducto, Productos.Nombre_Producto, Productos.Precio,
                      Ventas.vendido*Productos.Precio AS Venta,
                      Proveedor.Nombre_Proveedor
                      FROM Productos
                      INNER JOIN Proveedor ON Productos.idProveedor=Proveedor.idProveedor
                      LEFT JOIN Ventas ON Productos.idProducto=Ventas.idProducto ";
            if (!string.IsNullOrEmpty(query)) sql += "WHERE Productos.Nombre_Producto  LIKE '" + query + "%' ";
            sql += "AND Ventas.Fecha='" + comboFecha.SelectedItem.ToString() +"'";
            sql += optOrder;
            SQLConn conn2 = new SQLConn();
            conn2.Connection();
            command = new SqlCommand(sql, conn2.conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
              {
                table.RowCount++;
                panel1.Height = table.RowCount * 30;
                Label myLab = new Label();
                myLab.Width = 200;
                myLab.AutoSize=true;
                myLab.Anchor = AnchorStyles.None;
                myLab.Dock = DockStyle.Fill;
                Label labID = new Label();
                labID.TextAlign = ContentAlignment.MiddleCenter;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                labID.Text = dataReader.GetValue(0).ToString();
                table.Controls.Add(labID, 0, table.RowCount - 1);
                myLab.Text = dataReader.GetValue(1).ToString();
                table.Controls.Add(myLab, 1, table.RowCount - 1);
                table.Controls.Add(new Label() { Text = "$" + dataReader.GetValue(2).ToString() }, 2, table.RowCount - 1);
                table.Controls.Add(new Label() { Text = "$" + dataReader.GetValue(3).ToString() }, 3, table.RowCount - 1);
                table.Controls.Add(new Label() { Text = dataReader.GetValue(4).ToString() }, 4, table.RowCount - 1);
            }
            dataReader.Close();
            table.Visible = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void labelID_Click(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            if (textBox1.Text.Equals("Buscar")) query = "";
            if (string.IsNullOrEmpty(orderID) || orderID.Contains("ASC")) orderID = "ORDER BY Productos.idProducto DESC";
            else orderID = "ORDER BY Productos.idProducto ASC";
            searchProduct(query, orderID);
        }

        private void labelProducto_Click(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            if (textBox1.Text.Equals("Buscar")) query = "";
            if (string.IsNullOrEmpty(orderProductos) || orderProductos.Contains("ASC")) orderProductos = "ORDER BY Productos.Nombre_Producto DESC";
            else orderProductos = "ORDER BY Productos.Nombre_Producto ASC";
            searchProduct(query, orderProductos);
        }

        private void labelPrecio_Click(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            if (textBox1.Text.Equals("Buscar")) query = "";
            if (string.IsNullOrEmpty(orderPrecio) || orderPrecio.Contains("ASC")) orderPrecio = "ORDER BY Productos.Precio DESC";
            else orderPrecio = "ORDER BY Productos.Precio ASC";
            searchProduct(query, orderPrecio);
        }

        private void labelVenta_Click(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            if (textBox1.Text.Equals("Buscar")) query = "";
            if (string.IsNullOrEmpty(orderVentas) || orderVentas.Contains("ASC")) orderVentas = "ORDER BY Venta DESC";
            else orderVentas = "ORDER BY Venta ASC";
            searchProduct(query, orderVentas);
        }

        private void labelProveedor_Click(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            if (textBox1.Text.Equals("Buscar")) query = "";
            if (string.IsNullOrEmpty(orderProveedores) || orderProveedores.Contains("ASC")) orderProveedores = "ORDER BY Proveedor.Nombre_Proveedor DESC";
            else orderProveedores = "ORDER BY Proveedor.Nombre_Proveedor ASC";
            searchProduct(query, orderProveedores);
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnInsertProv_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void cargarComboFecha() {
            sql = "SELECT Distinct(Fecha) from Ventas";
            conn2.Connection();
            command = new SqlCommand(sql, conn2.conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                comboFecha.Items.Add(dataReader.GetValue(0).ToString());
            }
            comboFecha.SelectedIndex = 0;
            dataReader.Close();
        }

        private void comboFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = textBox1.Text;
            if (textBox1.Text.Equals("Buscar")) query = "";
            searchProduct(query);
            ventaDiaria();
        }

        private void ventaDiaria() {
            sql = @"SELECT SUM(Ventas.vendido*Productos.Precio) AS Venta
                  FROM Productos
                  LEFT JOIN Ventas ON Productos.idProducto=Ventas.idProducto
                  WHERE Ventas.Fecha='" + comboFecha.SelectedItem.ToString() + "'";
            SQLConn conn2 = new SQLConn();
            conn2.Connection();
            command = new SqlCommand(sql, conn2.conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtVentaDiaria.Text = "$" + dataReader.GetValue(0).ToString();
            }
            dataReader.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro que desea resetear las tablas a sus valores originales",
                                     "Resetear tablas",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                consulta.resetTables();
            }
        }

         
    }
}
