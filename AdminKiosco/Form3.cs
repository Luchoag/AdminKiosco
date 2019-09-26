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
    public partial class Form3 : Form
    {
        SqlCommand command;
        SqlDataReader dataReader;
        String sql = "";
        SQLConn conn2 = new SQLConn();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos() {
            txtBoxNombreProv.Text = "";
            txtCUIL.Text = "";
            txtDomicilio.Text = "";
            txtTel.Text = "";
            labNombreError.Visible = false;
            labelCamposError.Visible = false;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (checkNombre() && checkCampoCuilTel(txtCUIL.Text) && checkCampoDomicilio(txtDomicilio.Text) && checkCampoCuilTel(txtTel.Text))
            {
                addToDatabase();
                MessageBox.Show("¡Proveedor agreagado a la base de datos!");
                limpiarCampos();
            }
        }

        public bool checkNombre()
        {
            if (string.IsNullOrEmpty(txtBoxNombreProv.Text) || txtBoxNombreProv.TextLength > 20)
            {
                labNombreError.Text = "Nombre introducido no válido";
                labNombreError.Visible = true;
                return false;
            }
            else if (compareToDatabase())
            {
                labNombreError.Text = "El proveedor ya existe";
                labNombreError.Visible = true;
                return false;
            }
            else
            {
                labNombreError.Visible = false;
                return true;
            }
        }

        public bool compareToDatabase()
        {
            sql = "SELECT Nombre_Proveedor from Proveedor";
            conn2.Connection();
            command = new SqlCommand(sql, conn2.conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if (txtBoxNombreProv.Text == dataReader.GetValue(0).ToString())
                {
                    return true;
                }
            }
            dataReader.Close();
            return false;
        }

        private bool checkCampoCuilTel(String campo) {
            if (string.IsNullOrEmpty(campo) || campo.Length > 11)
            {
                labelCamposError.Visible = true;
                return false;
            }
            else return true;
        }

        private bool checkCampoDomicilio(String campo)
        {
            if (string.IsNullOrEmpty(campo) || campo.Length > 45)
            {
                labelCamposError.Visible = true;
                return false;
            }
            else return true;
        }

        private void addToDatabase()
        {
            String sql = "";
            sql = "INSERT INTO Proveedor(Nombre_Proveedor, CUIL, Domicilio, Telefono) values (@Prov, @CUIL, @Domic, @Tel)";
            using (SqlCommand cmd = new SqlCommand(sql, conn2.conn))
            {
                cmd.Parameters.AddWithValue("@Prov", txtBoxNombreProv.Text);
                cmd.Parameters.AddWithValue("@CUIL", txtCUIL.Text);
                cmd.Parameters.AddWithValue("@Domic", txtDomicilio.Text);
                cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
