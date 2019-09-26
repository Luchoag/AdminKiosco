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
    public partial class Form2 : Form
    {
        SqlCommand command;
        SqlDataReader dataReader;
        String sql = "";
        SQLConn conn2 = new SQLConn();
        SQLQueries consulta = new SQLQueries();
        
        public Form2()

        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtBoxNombreProd.Text = "";
            txtPrecio.Text = "";
            comboProv.Items.Clear();
            cargarComboProv();
            labelPrecioError.Visible = false;
            labNombreError.Visible = false;
        }

        private void cargarComboProv() {
            consulta.cargarComboProv(comboProv);
            comboProv.SelectedIndex = 0;
        }
        

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtBoxNombreProd.Text = "";
            txtPrecio.Text = "";
            comboProv.SelectedIndex = 0;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (checkNombre() && checkPrecio()) {
                addToDatabase();
                MessageBox.Show("¡Producto agreagado a la base de datos!");
                btnLimpiarForm_Click(sender, e);
            }
        }

        public bool checkNombre () {
            if (string.IsNullOrEmpty(txtBoxNombreProd.Text) || txtBoxNombreProd.TextLength>30){
                labNombreError.Text = "Nombre introducido no válido";
                labNombreError.Visible = true;
                return false;
            } else if (compareToDatabase()) {
                labNombreError.Text = "El producto ya existe";
                labNombreError.Visible = true;
                return false;
            } else {
                labNombreError.Visible = false;
                return true;
            }
        }

        public bool compareToDatabase() {
            sql = "SELECT Nombre_Producto from Productos";
            conn2.Connection();
            command = new SqlCommand(sql, conn2.conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (txtBoxNombreProd.Text==dataReader.GetValue(0).ToString()) {
                    return true;
                }
            }
            dataReader.Close();
            return false;
        }

        private bool checkPrecio() {
            float f;
            bool precio = float.TryParse(txtPrecio.Text, out f);
            if (!precio) labelPrecioError.Visible = true;
            else labelPrecioError.Visible = false;
            return precio;
        }

        private void addToDatabase() {
            String sql = "";
            sql = "INSERT INTO Productos(Nombre_Producto, Precio, idProveedor) values (@Prod, @Precio, @idProv)";
            using (SqlCommand cmd = new SqlCommand(sql, conn2.conn))
            {
                cmd.Parameters.AddWithValue("@Prod", txtBoxNombreProd.Text);
                float fPrecio = float.Parse(txtPrecio.Text);
                cmd.Parameters.AddWithValue("@Precio", fPrecio);
                cmd.Parameters.AddWithValue("@idProv", comboProv.SelectedIndex+1);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
