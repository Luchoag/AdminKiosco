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
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace AdminKiosco
{
    class SQLQueries
    {
        private String sql = "";
        private SQLConn conn2 = new SQLConn();

        public SQLQueries() { }


        public void cargarComboProd(ComboBox comboProd)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT Nombre_Producto from Productos"), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    comboProd.Items.Add(dataReader.GetValue(0).ToString());
                }
                comboProd.SelectedIndex = 0;
            }
        }

        public void cargarComboProv(ComboBox comboProv)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = "SELECT Nombre_Proveedor from Proveedor";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    comboProv.Items.Add(dataReader.GetValue(0).ToString());
                }
            }
        }

        public void selectComboProvIndex (ComboBox comboProv, ComboBox comboProd) {
            for (int i = 0; i < comboProv.Items.Count; i++)
            {
                comboProv.SelectedIndex = i;
                if (comboProv.SelectedItem.ToString() == getProveedor(comboProd))
                {
                    break;
                }
            }
        }
        public int getIdProducto(String producto)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = "SELECT idProducto, Nombre_Producto from Productos";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (producto == dataReader.GetValue(1).ToString())
                    {
                        return Convert.ToInt32(dataReader.GetValue(0));
                    }
                }
                return -1;
            }
        }

        public float getPrecio(ComboBox comboProd)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = "SELECT Nombre_Producto, Precio from Productos";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (comboProd.SelectedItem.ToString() == dataReader.GetValue(0).ToString())
                    {
                        return (float)Convert.ToDouble(dataReader.GetValue(1));
                    }
                }
                return -1;
            }
        }

        public String getProveedor(ComboBox comboProd)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = @"SELECT Productos.Nombre_Producto, Productos.idProveedor, Proveedor.Nombre_Proveedor from Productos
                   INNER JOIN Proveedor ON Productos.idProveedor=Proveedor.idProveedor";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (comboProd.SelectedItem.ToString() == dataReader.GetValue(0).ToString())
                    {
                        return dataReader.GetValue(2).ToString();
                    }
                }
                return "Error";
            }
        }

        public int getIdProveedor(String proveedor) {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = "SELECT Proveedor.idProveedor, Proveedor.Nombre_Proveedor from Proveedor";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (proveedor == dataReader.GetValue(1).ToString())
                    {
                        return Convert.ToInt32(dataReader.GetValue(0));
                    }
                }
                return -1;
            }

        }
        public void updateProducts (String producto, String nuevoNombre, float nuevoPrecio, int nuevoIdProveedor) {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                sql = @"UPDATE Productos
                  SET Nombre_Producto = @Prod, Precio = @Precio, idProveedor = @idProv
                  WHERE Nombre_Producto = '" + producto + "'";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Prod", nuevoNombre);
                cmd.Parameters.AddWithValue("@Precio", nuevoPrecio);
                cmd.Parameters.AddWithValue("@idProv", nuevoIdProveedor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("¡Cambios aplicados con éxito!");
            }
        }

        public void getProveedorData (String proveedor, TextBox txtNombre, TextBox txtCuil, TextBox txtDomic, TextBox txtTel) {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = @"SELECT Nombre_Proveedor, CUIL, Domicilio, Telefono from Proveedor
                      WHERE Nombre_Proveedor = '" + proveedor + "'";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    txtNombre.Text = dataReader.GetValue(0).ToString();
                    txtCuil.Text = dataReader.GetValue(1).ToString();
                    txtDomic.Text = dataReader.GetValue(2).ToString();
                    txtTel.Text = dataReader.GetValue(3).ToString();
                }
            }
        }

        public void updateProveedores(String proveedor, String nuevoNombre, String nuevoCuil, String nuevoDomicilio, String nuevoTelefono)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                sql = @"UPDATE Proveedor
                  SET Nombre_Proveedor = @Prov, CUIL = @Cuil, Domicilio = @Domic, Telefono = @Tel
                  WHERE Nombre_Proveedor = '" + proveedor + "'";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Prov", nuevoNombre);
                cmd.Parameters.AddWithValue("@Cuil", nuevoCuil);
                cmd.Parameters.AddWithValue("@Domic", nuevoDomicilio);
                cmd.Parameters.AddWithValue("@Tel", nuevoTelefono);
                cmd.ExecuteNonQuery();
                MessageBox.Show("¡Cambios aplicados con éxito!");
            }
        }

        public void cargarComboFecha(ComboBox comboFecha)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = "SELECT Distinct(Fecha) from Ventas"; ;
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    comboFecha.Items.Add(dataReader.GetValue(0).ToString());
                }
            }
        }

        public void cargarComboProdTab3(String fecha, ComboBox comboProd) {
            comboProd.Items.Clear();
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = @"SELECT Productos.Nombre_Producto, Ventas.Fecha FROM Productos
                      INNER JOIN Ventas ON Productos.idProducto=Ventas.idProducto
                      WHERE Ventas.Fecha = '" + fecha + "'";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    comboProd.Items.Add(dataReader.GetValue(0).ToString());
                }
            }
         }

        public void getVentasData(String fecha, int idProducto, TextBox txtIngreso, TextBox txtVendido)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            {
                con.Open();
                sql = @"SELECT Ingresado, Vendido from Ventas
                      WHERE Fecha = '" + fecha + @"'
                      AND idProducto =" + idProducto + "";
                SqlCommand cmd = new SqlCommand(string.Format(sql), con);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    txtIngreso.Text = dataReader.GetValue(0).ToString();
                    txtVendido.Text = dataReader.GetValue(1).ToString();
                }
            }
        }

        public void updateVentas(String fecha, int idProducto, int nuevoIngresado, int nuevoVendido)
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                sql = @"UPDATE Ventas
                      SET Ingresado = @Ingreso, Vendido = @Bendido
                      WHERE Fecha = '" + fecha + "' AND idProducto = " + idProducto + "";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Prod", nuevoIngresado);
                cmd.Parameters.AddWithValue("@Precio", nuevoVendido);
                cmd.ExecuteNonQuery();
                MessageBox.Show("¡Cambios aplicados con éxito!");
            }
        }

        public void deleteProducts(String producto) {
            try {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        sql = @"DELETE FROM Productos
                               WHERE Nombre_Producto = @Prod";
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@Prod", producto);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Producto eliminado de la base de datos!", "Eliminación completada");
                    }
                } catch {
                    MessageBox.Show("Existen ventas asociadas a este producto y no se puede eliminar.", "Error al eliminar");
                }
        }

        public void deleteProveedor(String proveedor)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    sql = @"DELETE FROM Proveedor
                               WHERE Nombre_Proveedor = @Prov";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Prov", proveedor);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("¡Proveedor eliminado de la base de datos!", "Eliminación completada");
                }
            }
            catch
            {
                MessageBox.Show("Existen productos asociados a este proveedor y no se puede eliminar.", "Error al eliminar");
            }
        }

        public void deleteVentas(String fecha, String producto)
        {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    sql = @"DELETE FROM Ventas
                               WHERE Fecha = @Fecha AND idProducto= @idProd ";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@idProd", getIdProducto(producto));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("¡Venta eliminada de la base de datos!", "Eliminación completada");
                }
        }

        public void resetTables () {
            //FileInfo file = new FileInfo("C:\\ProyectoIntegración.sql");
            //string script = file.OpenText().ReadToEnd();
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["AdminKiosco.Properties.Settings.db1ConnectionString"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn2.conn))
            {
                Server server = new Server(new ServerConnection(con));
                var script = AdminKiosco.Properties.Resources.ProyectoIntegración;
                server.ConnectionContext.ExecuteNonQuery(script);
            }
        }

    }   //end Class
} //end namespace
