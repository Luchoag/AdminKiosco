namespace AdminKiosco
{
    partial class Form5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPrecioError = new System.Windows.Forms.Label();
            this.btnAplicarProd = new System.Windows.Forms.Button();
            this.comboProv = new System.Windows.Forms.ComboBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboProd = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDomic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAplicarProv = new System.Windows.Forms.Button();
            this.comboProvTab2 = new System.Windows.Forms.ComboBox();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblIngrError = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboFecha = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVendido = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboProdTab3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 406);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPrecioError);
            this.tabPage1.Controls.Add(this.btnAplicarProd);
            this.tabPage1.Controls.Add(this.comboProv);
            this.tabPage1.Controls.Add(this.txtPrecioProd);
            this.tabPage1.Controls.Add(this.txtNombreProd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboProd);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelPrecioError
            // 
            this.labelPrecioError.AutoSize = true;
            this.labelPrecioError.ForeColor = System.Drawing.Color.Crimson;
            this.labelPrecioError.Location = new System.Drawing.Point(143, 195);
            this.labelPrecioError.Name = "labelPrecioError";
            this.labelPrecioError.Size = new System.Drawing.Size(206, 20);
            this.labelPrecioError.TabIndex = 9;
            this.labelPrecioError.Text = "Precio ingresado no válido";
            this.labelPrecioError.Visible = false;
            // 
            // btnAplicarProd
            // 
            this.btnAplicarProd.Location = new System.Drawing.Point(211, 290);
            this.btnAplicarProd.Name = "btnAplicarProd";
            this.btnAplicarProd.Size = new System.Drawing.Size(147, 45);
            this.btnAplicarProd.TabIndex = 8;
            this.btnAplicarProd.Text = "Aplicar cambios";
            this.btnAplicarProd.UseVisualStyleBackColor = true;
            this.btnAplicarProd.Click += new System.EventHandler(this.btnAplicarProd_Click);
            // 
            // comboProv
            // 
            this.comboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProv.FormattingEnabled = true;
            this.comboProv.Location = new System.Drawing.Point(147, 233);
            this.comboProv.Name = "comboProv";
            this.comboProv.Size = new System.Drawing.Size(211, 28);
            this.comboProv.TabIndex = 7;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(147, 165);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(211, 27);
            this.txtPrecioProd.TabIndex = 6;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(147, 105);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(211, 27);
            this.txtNombreProd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto:";
            // 
            // comboProd
            // 
            this.comboProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProd.FormattingEnabled = true;
            this.comboProd.Location = new System.Drawing.Point(147, 37);
            this.comboProd.Name = "comboProd";
            this.comboProd.Size = new System.Drawing.Size(211, 28);
            this.comboProd.TabIndex = 0;
            this.comboProd.SelectedIndexChanged += new System.EventHandler(this.comboProd_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTel);
            this.tabPage2.Controls.Add(this.txtDomic);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnAplicarProv);
            this.tabPage2.Controls.Add(this.comboProvTab2);
            this.tabPage2.Controls.Add(this.txtCUIL);
            this.tabPage2.Controls.Add(this.txtNombreProv);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(159, 252);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(211, 27);
            this.txtTel.TabIndex = 22;
            // 
            // txtDomic
            // 
            this.txtDomic.Location = new System.Drawing.Point(159, 192);
            this.txtDomic.Name = "txtDomic";
            this.txtDomic.Size = new System.Drawing.Size(211, 27);
            this.txtDomic.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Domicilio:";
            // 
            // btnAplicarProv
            // 
            this.btnAplicarProv.Location = new System.Drawing.Point(223, 303);
            this.btnAplicarProv.Name = "btnAplicarProv";
            this.btnAplicarProv.Size = new System.Drawing.Size(147, 45);
            this.btnAplicarProv.TabIndex = 18;
            this.btnAplicarProv.Text = "Aplicar cambios";
            this.btnAplicarProv.UseVisualStyleBackColor = true;
            this.btnAplicarProv.Click += new System.EventHandler(this.btnAplicarProv_Click);
            // 
            // comboProvTab2
            // 
            this.comboProvTab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvTab2.FormattingEnabled = true;
            this.comboProvTab2.Location = new System.Drawing.Point(159, 28);
            this.comboProvTab2.Name = "comboProvTab2";
            this.comboProvTab2.Size = new System.Drawing.Size(211, 28);
            this.comboProvTab2.TabIndex = 17;
            this.comboProvTab2.SelectedIndexChanged += new System.EventHandler(this.comboProvTab2_SelectedIndexChanged);
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(159, 136);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(211, 27);
            this.txtCUIL.TabIndex = 16;
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(159, 85);
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(211, 27);
            this.txtNombreProv.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "CUIL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nombre:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblIngrError);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.comboFecha);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtVendido);
            this.tabPage3.Controls.Add(this.txtIngreso);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.comboProdTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(401, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblIngrError
            // 
            this.lblIngrError.AutoSize = true;
            this.lblIngrError.ForeColor = System.Drawing.Color.Crimson;
            this.lblIngrError.Location = new System.Drawing.Point(224, 192);
            this.lblIngrError.Name = "lblIngrError";
            this.lblIngrError.Size = new System.Drawing.Size(135, 20);
            this.lblIngrError.TabIndex = 21;
            this.lblIngrError.Text = "Ingreso no válido";
            this.lblIngrError.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha:";
            // 
            // comboFecha
            // 
            this.comboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFecha.FormattingEnabled = true;
            this.comboFecha.Location = new System.Drawing.Point(159, 35);
            this.comboFecha.Name = "comboFecha";
            this.comboFecha.Size = new System.Drawing.Size(211, 28);
            this.comboFecha.TabIndex = 19;
            this.comboFecha.SelectedIndexChanged += new System.EventHandler(this.comboFecha_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Aplicar cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVendido
            // 
            this.txtVendido.Location = new System.Drawing.Point(223, 228);
            this.txtVendido.Name = "txtVendido";
            this.txtVendido.Size = new System.Drawing.Size(147, 27);
            this.txtVendido.TabIndex = 16;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(224, 157);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(146, 27);
            this.txtIngreso.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Cantidad vendida:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cantidad ingresada:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "Producto:";
            // 
            // comboProdTab3
            // 
            this.comboProdTab3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProdTab3.FormattingEnabled = true;
            this.comboProdTab3.Location = new System.Drawing.Point(159, 98);
            this.comboProdTab3.Name = "comboProdTab3";
            this.comboProdTab3.Size = new System.Drawing.Size(211, 28);
            this.comboProdTab3.TabIndex = 10;
            this.comboProdTab3.SelectedIndexChanged += new System.EventHandler(this.comboProdTab3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actualizar un registro";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 435);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Modificar registros";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProv;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Button btnAplicarProd;
        private System.Windows.Forms.Label labelPrecioError;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDomic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAplicarProv;
        private System.Windows.Forms.ComboBox comboProvTab2;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVendido;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboProdTab3;
        private System.Windows.Forms.Label lblIngrError;

    }
}