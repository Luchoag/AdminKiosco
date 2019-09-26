namespace AdminKiosco
{
    partial class Form2
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
            this.lblTituloIns = new System.Windows.Forms.Label();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.lblPrecioProdu = new System.Windows.Forms.Label();
            this.lblElegirProv = new System.Windows.Forms.Label();
            this.txtBoxNombreProd = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.comboProv = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.labNombreError = new System.Windows.Forms.Label();
            this.labelPrecioError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloIns
            // 
            this.lblTituloIns.AutoSize = true;
            this.lblTituloIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIns.Location = new System.Drawing.Point(12, 18);
            this.lblTituloIns.Name = "lblTituloIns";
            this.lblTituloIns.Size = new System.Drawing.Size(232, 29);
            this.lblTituloIns.TabIndex = 0;
            this.lblTituloIns.Text = "Insertar un producto:";
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Location = new System.Drawing.Point(24, 250);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(140, 50);
            this.btnLimpiarForm.TabIndex = 9;
            this.btnLimpiarForm.Text = "Limpiar Formulario";
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProd.Location = new System.Drawing.Point(9, 71);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(87, 25);
            this.lblNombreProd.TabIndex = 3;
            this.lblNombreProd.Text = "Nombre:";
            // 
            // lblPrecioProdu
            // 
            this.lblPrecioProdu.AutoSize = true;
            this.lblPrecioProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProdu.Location = new System.Drawing.Point(9, 132);
            this.lblPrecioProdu.Name = "lblPrecioProdu";
            this.lblPrecioProdu.Size = new System.Drawing.Size(73, 25);
            this.lblPrecioProdu.TabIndex = 4;
            this.lblPrecioProdu.Text = "Precio:";
            // 
            // lblElegirProv
            // 
            this.lblElegirProv.AutoSize = true;
            this.lblElegirProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirProv.Location = new System.Drawing.Point(9, 204);
            this.lblElegirProv.Name = "lblElegirProv";
            this.lblElegirProv.Size = new System.Drawing.Size(108, 25);
            this.lblElegirProv.TabIndex = 5;
            this.lblElegirProv.Text = "Proveedor:";
            // 
            // txtBoxNombreProd
            // 
            this.txtBoxNombreProd.Location = new System.Drawing.Point(154, 71);
            this.txtBoxNombreProd.Name = "txtBoxNombreProd";
            this.txtBoxNombreProd.Size = new System.Drawing.Size(196, 22);
            this.txtBoxNombreProd.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(154, 134);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(196, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // comboProv
            // 
            this.comboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProv.FormattingEnabled = true;
            this.comboProv.Location = new System.Drawing.Point(154, 203);
            this.comboProv.Name = "comboProv";
            this.comboProv.Size = new System.Drawing.Size(196, 24);
            this.comboProv.TabIndex = 8;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(198, 250);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(140, 50);
            this.btnAplicar.TabIndex = 10;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // labNombreError
            // 
            this.labNombreError.AutoSize = true;
            this.labNombreError.ForeColor = System.Drawing.Color.Crimson;
            this.labNombreError.Location = new System.Drawing.Point(156, 96);
            this.labNombreError.Name = "labNombreError";
            this.labNombreError.Size = new System.Drawing.Size(193, 17);
            this.labNombreError.TabIndex = 10;
            this.labNombreError.Text = "Nombre introducido no válido";
            this.labNombreError.Visible = false;
            // 
            // labelPrecioError
            // 
            this.labelPrecioError.AutoSize = true;
            this.labelPrecioError.ForeColor = System.Drawing.Color.Crimson;
            this.labelPrecioError.Location = new System.Drawing.Point(154, 163);
            this.labelPrecioError.Name = "labelPrecioError";
            this.labelPrecioError.Size = new System.Drawing.Size(109, 17);
            this.labelPrecioError.TabIndex = 11;
            this.labelPrecioError.Text = "Precio no válido";
            this.labelPrecioError.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 310);
            this.Controls.Add(this.labelPrecioError);
            this.Controls.Add(this.labNombreError);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.comboProv);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtBoxNombreProd);
            this.Controls.Add(this.lblElegirProv);
            this.Controls.Add(this.lblPrecioProdu);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.lblTituloIns);
            this.Name = "Form2";
            this.Text = "Agregar un producto";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloIns;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Label lblPrecioProdu;
        private System.Windows.Forms.Label lblElegirProv;
        private System.Windows.Forms.TextBox txtBoxNombreProd;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox comboProv;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label labNombreError;
        private System.Windows.Forms.Label labelPrecioError;
    }
}