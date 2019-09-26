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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db1DataSet1.Ventas_audit' Puede moverla o quitarla según sea necesario.
            this.ventas_auditTableAdapter.Fill(this.db1DataSet1.Ventas_audit);
            // TODO: esta línea de código carga datos en la tabla 'db1DataSet1.Productos_audit' Puede moverla o quitarla según sea necesario.
            this.productos_auditTableAdapter.Fill(this.db1DataSet1.Productos_audit);
            // TODO: esta línea de código carga datos en la tabla 'db1DataSet1.Proveedor_audit' Puede moverla o quitarla según sea necesario.
            this.proveedor_auditTableAdapter.Fill(this.db1DataSet1.Proveedor_audit);
            // TODO: esta línea de código carga datos en la tabla 'db1DataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.db1DataSet.Proveedor);

        }
    }
}
