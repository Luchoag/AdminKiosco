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

namespace AdminKiosco
{
    public partial class Form4 : Form
    {
        SqlCommand command;
        SqlDataReader dataReader;
        String sql = "";
        SQLConn conn2 = new SQLConn();
        SQLQueries consulta = new SQLQueries();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            limpiarForm();
            cargarFecha();
        }

        private void limpiarForm() {
            txtIngr.Text = "";
            txtVend.Text = "";
            txtFact.Text = "";
            comboProd.Items.Clear();
            cargarComboProd();
            lblFechaError.Visible = false;
            lblIngrError.Visible = false;
        }

        private void cargarFecha()
        {
            txtDia.Text = DateTime.Now.Day.ToString();
            txtMes.Text = DateTime.Now.Month.ToString();
            txtAño.Text = DateTime.Now.Year.ToString();
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void cargarComboProd()
        {
            consulta.cargarComboProd(comboProd);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (checkDate()){
                if (compareToDatabase() && checkNumbers(txtIngr) && checkNumbers(txtVend)) {
                    addToDatabase();
                    MessageBox.Show("¡Venta agreagada a la base de datos!");
                    limpiarForm();
                }
            }
        }

        private bool checkDate() {
            String fecha = txtDia.Text + "-" + txtMes.Text + "-" + txtAño.Text;
            DateTime temp;
            if (DateTime.TryParse(fecha, out temp)) return true;
            else {
                lblFechaError.Visible=true;
                return false;
            }
       }

        public bool compareToDatabase()
        {
            sql = @"SELECT Ventas.Fecha, Ventas.idProducto, Productos.Nombre_Producto from Ventas
                   JOIN Productos ON Ventas.idProducto=Productos.idProducto";
            conn2.Connection();
            command = new SqlCommand(sql, conn2.conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (getDateFromText() == dataReader.GetValue(0).ToString() && comboProd.SelectedItem.ToString()==dataReader.GetValue(2).ToString())
                {
                    MessageBox.Show("La venta ya existe en la base de datos.");
                    return false;
                }
            }

            dataReader.Close();
            return true;
        }
        private String getDateFromText() {
            String fecha = txtDia.Text + "-" + txtMes.Text + "-" + txtAño.Text;
            DateTime date = Convert.ToDateTime(fecha);
            return date.ToString();
        }
        private void addToDatabase() {
            String sql = "";
            sql = "INSERT INTO Ventas(Fecha, idProducto, Ingresado, Vendido) values (@Fecha, @idProducto, @Ingreso, @Venta)";
            using (SqlCommand cmd = new SqlCommand(sql, conn2.conn))
            {
                cmd.Parameters.AddWithValue("@Fecha", getDateFromText());
                cmd.Parameters.AddWithValue("@idProducto", consulta.getIdProducto(comboProd.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@ingreso", txtIngr.Text);
                cmd.Parameters.AddWithValue("@venta", txtVend.Text);
                cmd.ExecuteNonQuery();
            }
        }

        private bool checkNumbers(TextBox txt)
        {
            int i;
            bool number = int.TryParse(txt.Text, out i);
            Point controlLoc = this.PointToScreen(txt.Location);
            lblIngrError.Location = new Point(200, controlLoc.Y - this.Location.Y-4); 
            if (!number) {
                lblIngrError.Visible = true;
            }
            else lblIngrError.Visible = false;
            return number;
        }

        private void txtVend_KeyUp(object sender, KeyEventArgs e)
        {
            setFact();
        }

        private void comboProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFact();
        }

        private void setFact() {
            if (checkNumbers(txtVend))
            {
                sql = @"SELECT Productos.Precio, Nombre_Producto from Productos
                   JOIN Ventas ON Ventas.idProducto=Productos.idProducto";
                conn2.Connection();
                command = new SqlCommand(sql, conn2.conn);
                dataReader = command.ExecuteReader();
                int vendido = Convert.ToInt32(txtVend.Text);
                while (dataReader.Read())
                {
                    if (comboProd.SelectedItem.ToString()==dataReader.GetValue(1).ToString()) {
                    int precio = Convert.ToInt32(dataReader.GetValue(0));
                    txtFact.Text = (precio * vendido).ToString();
                    }
                }

                dataReader.Close();
            }
            else txtFact.Text = "";
        }
    }
}
