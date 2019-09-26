namespace AdminKiosco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInsertProv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboFecha = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtVentaDiaria = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelVenta = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.lblVentaDiaria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.table.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnInsert);
            this.splitContainer1.Panel1.Controls.Add(this.btnInsertProv);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.comboFecha);
            this.splitContainer1.Panel1.Controls.Add(this.btnModificar);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1MinSize = 15;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.txtVentaDiaria);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.lblVentaDiaria);
            this.splitContainer1.Size = new System.Drawing.Size(917, 502);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInsert.Location = new System.Drawing.Point(16, 64);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 52);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insertar Producto";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertProv
            // 
            this.btnInsertProv.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInsertProv.Location = new System.Drawing.Point(16, 122);
            this.btnInsertProv.Name = "btnInsertProv";
            this.btnInsertProv.Size = new System.Drawing.Size(92, 52);
            this.btnInsertProv.TabIndex = 4;
            this.btnInsertProv.Text = "Insertar Proveedor";
            this.btnInsertProv.UseVisualStyleBackColor = false;
            this.btnInsertProv.Click += new System.EventHandler(this.btnInsertProv_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(16, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Insertar Ventas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button4.Location = new System.Drawing.Point(16, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 52);
            this.button4.TabIndex = 8;
            this.button4.Text = "Historial de cambios";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboFecha
            // 
            this.comboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFecha.FormattingEnabled = true;
            this.comboFecha.Location = new System.Drawing.Point(4, 17);
            this.comboFecha.Name = "comboFecha";
            this.comboFecha.Size = new System.Drawing.Size(112, 28);
            this.comboFecha.TabIndex = 5;
            this.comboFecha.SelectedIndexChanged += new System.EventHandler(this.comboFecha_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificar.Location = new System.Drawing.Point(16, 238);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 52);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar un registro";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.Location = new System.Drawing.Point(16, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar un registro";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(765, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Buscar";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtVentaDiaria
            // 
            this.txtVentaDiaria.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtVentaDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaDiaria.Location = new System.Drawing.Point(591, 441);
            this.txtVentaDiaria.Name = "txtVentaDiaria";
            this.txtVentaDiaria.ReadOnly = true;
            this.txtVentaDiaria.Size = new System.Drawing.Size(175, 30);
            this.txtVentaDiaria.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.table);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 34);
            this.panel1.TabIndex = 1;
            // 
            // table
            // 
            this.table.AutoScroll = true;
            this.table.BackColor = System.Drawing.SystemColors.HighlightText;
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.48639F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.40658F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.35023F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.35023F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.40657F));
            this.table.Controls.Add(this.labelProveedor, 4, 0);
            this.table.Controls.Add(this.labelVenta, 3, 0);
            this.table.Controls.Add(this.labelPrecio, 2, 0);
            this.table.Controls.Add(this.labelProducto, 1, 0);
            this.table.Controls.Add(this.labelID, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(765, 34);
            this.table.TabIndex = 0;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(541, 0);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(221, 34);
            this.labelProveedor.TabIndex = 4;
            this.labelProveedor.Text = "Proveedor";
            this.labelProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProveedor.Click += new System.EventHandler(this.labelProveedor_Click);
            // 
            // labelVenta
            // 
            this.labelVenta.AutoSize = true;
            this.labelVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenta.Location = new System.Drawing.Point(424, 0);
            this.labelVenta.Name = "labelVenta";
            this.labelVenta.Size = new System.Drawing.Size(111, 34);
            this.labelVenta.TabIndex = 3;
            this.labelVenta.Text = "Venta";
            this.labelVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVenta.Click += new System.EventHandler(this.labelVenta_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(307, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(111, 34);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            this.labelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrecio.Click += new System.EventHandler(this.labelPrecio_Click);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(83, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(218, 34);
            this.labelProducto.TabIndex = 1;
            this.labelProducto.Text = "Producto";
            this.labelProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProducto.Click += new System.EventHandler(this.labelProducto_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(3, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(74, 34);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // lblVentaDiaria
            // 
            this.lblVentaDiaria.AutoSize = true;
            this.lblVentaDiaria.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblVentaDiaria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentaDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaDiaria.Location = new System.Drawing.Point(436, 441);
            this.lblVentaDiaria.Name = "lblVentaDiaria";
            this.lblVentaDiaria.Size = new System.Drawing.Size(151, 31);
            this.lblVentaDiaria.TabIndex = 9;
            this.lblVentaDiaria.Text = "Venta Diaria:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 502);
            this.panel2.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.Location = new System.Drawing.Point(16, 420);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 52);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Resetear tablas";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 502);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "AdminKiosco";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnInsertProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboFecha;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtVentaDiaria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelVenta;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label lblVentaDiaria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;

    }
}

