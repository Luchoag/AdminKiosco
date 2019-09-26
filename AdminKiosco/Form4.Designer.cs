namespace AdminKiosco
{
    partial class Form4
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
            this.btnAplicar = new System.Windows.Forms.Button();
            this.comboProd = new System.Windows.Forms.ComboBox();
            this.txtIngr = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.lblElegirProd = new System.Windows.Forms.Label();
            this.lblIngr = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.lblTituloIns = new System.Windows.Forms.Label();
            this.lblVend = new System.Windows.Forms.Label();
            this.lblFact = new System.Windows.Forms.Label();
            this.txtVend = new System.Windows.Forms.TextBox();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaError = new System.Windows.Forms.Label();
            this.lblIngrError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(223, 395);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(140, 50);
            this.btnAplicar.TabIndex = 28;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // comboProd
            // 
            this.comboProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProd.FormattingEnabled = true;
            this.comboProd.Location = new System.Drawing.Point(199, 144);
            this.comboProd.Name = "comboProd";
            this.comboProd.Size = new System.Drawing.Size(196, 26);
            this.comboProd.TabIndex = 32;
            this.comboProd.SelectedIndexChanged += new System.EventHandler(this.comboProd_SelectedIndexChanged);
            // 
            // txtIngr
            // 
            this.txtIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngr.Location = new System.Drawing.Point(200, 201);
            this.txtIngr.Name = "txtIngr";
            this.txtIngr.Size = new System.Drawing.Size(196, 24);
            this.txtIngr.TabIndex = 25;
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(199, 85);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(47, 24);
            this.txtDia.TabIndex = 29;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblElegirProd
            // 
            this.lblElegirProd.AutoSize = true;
            this.lblElegirProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirProd.Location = new System.Drawing.Point(12, 140);
            this.lblElegirProd.Name = "lblElegirProd";
            this.lblElegirProd.Size = new System.Drawing.Size(96, 25);
            this.lblElegirProd.TabIndex = 16;
            this.lblElegirProd.Text = "Producto:";
            // 
            // lblIngr
            // 
            this.lblIngr.AutoSize = true;
            this.lblIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngr.Location = new System.Drawing.Point(13, 201);
            this.lblIngr.Name = "lblIngr";
            this.lblIngr.Size = new System.Drawing.Size(177, 24);
            this.lblIngr.TabIndex = 15;
            this.lblIngr.Text = "Cantidad ingresada:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 82);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 25);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Location = new System.Drawing.Point(50, 395);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(140, 50);
            this.btnLimpiarForm.TabIndex = 27;
            this.btnLimpiarForm.Text = "Limpiar Formulario";
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // lblTituloIns
            // 
            this.lblTituloIns.AutoSize = true;
            this.lblTituloIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIns.Location = new System.Drawing.Point(12, 21);
            this.lblTituloIns.Name = "lblTituloIns";
            this.lblTituloIns.Size = new System.Drawing.Size(168, 29);
            this.lblTituloIns.TabIndex = 12;
            this.lblTituloIns.Text = "Agregar venta:";
            // 
            // lblVend
            // 
            this.lblVend.AutoSize = true;
            this.lblVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVend.Location = new System.Drawing.Point(13, 262);
            this.lblVend.Name = "lblVend";
            this.lblVend.Size = new System.Drawing.Size(171, 25);
            this.lblVend.TabIndex = 21;
            this.lblVend.Text = "Cantidad vendida:";
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFact.Location = new System.Drawing.Point(13, 321);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(106, 25);
            this.lblFact.TabIndex = 22;
            this.lblFact.Text = "Facturado:";
            // 
            // txtVend
            // 
            this.txtVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVend.Location = new System.Drawing.Point(200, 262);
            this.txtVend.Name = "txtVend";
            this.txtVend.Size = new System.Drawing.Size(196, 24);
            this.txtVend.TabIndex = 26;
            this.txtVend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVend_KeyUp);
            // 
            // txtFact
            // 
            this.txtFact.Enabled = false;
            this.txtFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFact.Location = new System.Drawing.Point(200, 321);
            this.txtFact.Name = "txtFact";
            this.txtFact.ReadOnly = true;
            this.txtFact.Size = new System.Drawing.Size(196, 24);
            this.txtFact.TabIndex = 24;
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(271, 86);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(47, 24);
            this.txtMes.TabIndex = 30;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(348, 86);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(47, 24);
            this.txtAño.TabIndex = 31;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "/";
            // 
            // lblFechaError
            // 
            this.lblFechaError.AutoSize = true;
            this.lblFechaError.ForeColor = System.Drawing.Color.Crimson;
            this.lblFechaError.Location = new System.Drawing.Point(200, 116);
            this.lblFechaError.Name = "lblFechaError";
            this.lblFechaError.Size = new System.Drawing.Size(114, 17);
            this.lblFechaError.TabIndex = 29;
            this.lblFechaError.Text = "Fecha incorrecta";
            // 
            // lblIngrError
            // 
            this.lblIngrError.AutoSize = true;
            this.lblIngrError.ForeColor = System.Drawing.Color.Crimson;
            this.lblIngrError.Location = new System.Drawing.Point(202, 228);
            this.lblIngrError.Name = "lblIngrError";
            this.lblIngrError.Size = new System.Drawing.Size(116, 17);
            this.lblIngrError.TabIndex = 30;
            this.lblIngrError.Text = "Ingreso no válido";
            this.lblIngrError.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 457);
            this.Controls.Add(this.lblIngrError);
            this.Controls.Add(this.lblFechaError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.txtVend);
            this.Controls.Add(this.lblFact);
            this.Controls.Add(this.lblVend);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.comboProd);
            this.Controls.Add(this.txtIngr);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblElegirProd);
            this.Controls.Add(this.lblIngr);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.lblTituloIns);
            this.Name = "Form4";
            this.Text = "Agregar ventas";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ComboBox comboProd;
        private System.Windows.Forms.TextBox txtIngr;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label lblElegirProd;
        private System.Windows.Forms.Label lblIngr;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Label lblTituloIns;
        private System.Windows.Forms.Label lblVend;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.TextBox txtVend;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaError;
        private System.Windows.Forms.Label lblIngrError;
    }
}