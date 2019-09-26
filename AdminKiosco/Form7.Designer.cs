namespace AdminKiosco
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditactionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db1DataSet1 = new AdminKiosco.db1DataSet();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db1DataSet = new AdminKiosco.db1DataSet();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new AdminKiosco.db1DataSetTableAdapters.ProveedorTableAdapter();
            this.proveedor_auditTableAdapter = new AdminKiosco.db1DataSetTableAdapters.Proveedor_auditTableAdapter();
            this.productos_auditTableAdapter = new AdminKiosco.db1DataSetTableAdapters.Productos_auditTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ventasauditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventas_auditTableAdapter = new AdminKiosco.db1DataSetTableAdapters.Ventas_auditTableAdapter();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditactionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosauditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorauditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasauditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 382);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn1,
            this.auditactionDataGridViewTextBoxColumn1,
            this.modifieddateDataGridViewTextBoxColumn1,
            this.modifiedbyDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.productosauditBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(839, 343);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.cUILDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.auditactionDataGridViewTextBoxColumn,
            this.modifieddateDataGridViewTextBoxColumn,
            this.modifiedbyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorauditBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(845, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // idProveedorDataGridViewTextBoxColumn1
            // 
            this.idProveedorDataGridViewTextBoxColumn1.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn1.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn1.Name = "idProveedorDataGridViewTextBoxColumn1";
            // 
            // auditactionDataGridViewTextBoxColumn1
            // 
            this.auditactionDataGridViewTextBoxColumn1.DataPropertyName = "Audit_action";
            this.auditactionDataGridViewTextBoxColumn1.HeaderText = "Audit_action";
            this.auditactionDataGridViewTextBoxColumn1.Name = "auditactionDataGridViewTextBoxColumn1";
            // 
            // modifieddateDataGridViewTextBoxColumn1
            // 
            this.modifieddateDataGridViewTextBoxColumn1.DataPropertyName = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn1.HeaderText = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn1.Name = "modifieddateDataGridViewTextBoxColumn1";
            // 
            // modifiedbyDataGridViewTextBoxColumn1
            // 
            this.modifiedbyDataGridViewTextBoxColumn1.DataPropertyName = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn1.HeaderText = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn1.Name = "modifiedbyDataGridViewTextBoxColumn1";
            // 
            // productosauditBindingSource
            // 
            this.productosauditBindingSource.DataMember = "Productos_audit";
            this.productosauditBindingSource.DataSource = this.db1DataSet1;
            // 
            // db1DataSet1
            // 
            this.db1DataSet1.DataSetName = "db1DataSet";
            this.db1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre_Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            // 
            // cUILDataGridViewTextBoxColumn
            // 
            this.cUILDataGridViewTextBoxColumn.DataPropertyName = "CUIL";
            this.cUILDataGridViewTextBoxColumn.HeaderText = "CUIL";
            this.cUILDataGridViewTextBoxColumn.Name = "cUILDataGridViewTextBoxColumn";
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // auditactionDataGridViewTextBoxColumn
            // 
            this.auditactionDataGridViewTextBoxColumn.DataPropertyName = "Audit_action";
            this.auditactionDataGridViewTextBoxColumn.HeaderText = "Audit_action";
            this.auditactionDataGridViewTextBoxColumn.Name = "auditactionDataGridViewTextBoxColumn";
            // 
            // modifieddateDataGridViewTextBoxColumn
            // 
            this.modifieddateDataGridViewTextBoxColumn.DataPropertyName = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn.HeaderText = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn.Name = "modifieddateDataGridViewTextBoxColumn";
            // 
            // modifiedbyDataGridViewTextBoxColumn
            // 
            this.modifiedbyDataGridViewTextBoxColumn.DataPropertyName = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn.HeaderText = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn.Name = "modifiedbyDataGridViewTextBoxColumn";
            // 
            // proveedorauditBindingSource
            // 
            this.proveedorauditBindingSource.DataMember = "Proveedor_audit";
            this.proveedorauditBindingSource.DataSource = this.db1DataSet1;
            // 
            // db1DataSet
            // 
            this.db1DataSet.DataSetName = "db1DataSet";
            this.db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.db1DataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // proveedor_auditTableAdapter
            // 
            this.proveedor_auditTableAdapter.ClearBeforeFill = true;
            // 
            // productos_auditTableAdapter
            // 
            this.productos_auditTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn1,
            this.ingresadoDataGridViewTextBoxColumn,
            this.vendidoDataGridViewTextBoxColumn,
            this.auditactionDataGridViewTextBoxColumn2,
            this.modifieddateDataGridViewTextBoxColumn2,
            this.modifiedbyDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.ventasauditBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(839, 343);
            this.dataGridView3.TabIndex = 0;
            // 
            // ventasauditBindingSource
            // 
            this.ventasauditBindingSource.DataMember = "Ventas_audit";
            this.ventasauditBindingSource.DataSource = this.db1DataSet1;
            // 
            // ventas_auditTableAdapter
            // 
            this.ventas_auditTableAdapter.ClearBeforeFill = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // idProductoDataGridViewTextBoxColumn1
            // 
            this.idProductoDataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.Name = "idProductoDataGridViewTextBoxColumn1";
            // 
            // ingresadoDataGridViewTextBoxColumn
            // 
            this.ingresadoDataGridViewTextBoxColumn.DataPropertyName = "Ingresado";
            this.ingresadoDataGridViewTextBoxColumn.HeaderText = "Ingresado";
            this.ingresadoDataGridViewTextBoxColumn.Name = "ingresadoDataGridViewTextBoxColumn";
            // 
            // vendidoDataGridViewTextBoxColumn
            // 
            this.vendidoDataGridViewTextBoxColumn.DataPropertyName = "Vendido";
            this.vendidoDataGridViewTextBoxColumn.HeaderText = "Vendido";
            this.vendidoDataGridViewTextBoxColumn.Name = "vendidoDataGridViewTextBoxColumn";
            // 
            // auditactionDataGridViewTextBoxColumn2
            // 
            this.auditactionDataGridViewTextBoxColumn2.DataPropertyName = "Audit_action";
            this.auditactionDataGridViewTextBoxColumn2.HeaderText = "Audit_action";
            this.auditactionDataGridViewTextBoxColumn2.Name = "auditactionDataGridViewTextBoxColumn2";
            // 
            // modifieddateDataGridViewTextBoxColumn2
            // 
            this.modifieddateDataGridViewTextBoxColumn2.DataPropertyName = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn2.HeaderText = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn2.Name = "modifieddateDataGridViewTextBoxColumn2";
            // 
            // modifiedbyDataGridViewTextBoxColumn2
            // 
            this.modifiedbyDataGridViewTextBoxColumn2.DataPropertyName = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn2.HeaderText = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn2.Name = "modifiedbyDataGridViewTextBoxColumn2";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 382);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosauditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorauditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasauditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private db1DataSet db1DataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private db1DataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private db1DataSet db1DataSet1;
        private System.Windows.Forms.BindingSource proveedorauditBindingSource;
        private db1DataSetTableAdapters.Proveedor_auditTableAdapter proveedor_auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productosauditBindingSource;
        private db1DataSetTableAdapters.Productos_auditTableAdapter productos_auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditactionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ventasauditBindingSource;
        private db1DataSetTableAdapters.Ventas_auditTableAdapter ventas_auditTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditactionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn2;

    }
}