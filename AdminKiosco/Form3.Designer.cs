namespace AdminKiosco
{
    partial class Form3
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
            this.labNombreError = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtCUIL = new System.Windows.Forms.TextBox();
            this.txtBoxNombreProv = new System.Windows.Forms.TextBox();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.lblNombreProv = new System.Windows.Forms.Label();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.lblTituloIns = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCamposError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNombreError
            // 
            this.labNombreError.AutoSize = true;
            this.labNombreError.ForeColor = System.Drawing.Color.Crimson;
            this.labNombreError.Location = new System.Drawing.Point(166, 96);
            this.labNombreError.Name = "labNombreError";
            this.labNombreError.Size = new System.Drawing.Size(193, 17);
            this.labNombreError.TabIndex = 21;
            this.labNombreError.Text = "Nombre introducido no válido";
            this.labNombreError.Visible = false;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(219, 302);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(140, 50);
            this.btnAplicar.TabIndex = 22;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtCUIL
            // 
            this.txtCUIL.Location = new System.Drawing.Point(167, 128);
            this.txtCUIL.Name = "txtCUIL";
            this.txtCUIL.Size = new System.Drawing.Size(196, 22);
            this.txtCUIL.TabIndex = 18;
            // 
            // txtBoxNombreProv
            // 
            this.txtBoxNombreProv.Location = new System.Drawing.Point(164, 71);
            this.txtBoxNombreProv.Name = "txtBoxNombreProv";
            this.txtBoxNombreProv.Size = new System.Drawing.Size(196, 22);
            this.txtBoxNombreProv.TabIndex = 17;
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIL.Location = new System.Drawing.Point(22, 126);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(63, 25);
            this.lblCUIL.TabIndex = 15;
            this.lblCUIL.Text = "CUIL:";
            // 
            // lblNombreProv
            // 
            this.lblNombreProv.AutoSize = true;
            this.lblNombreProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProv.Location = new System.Drawing.Point(19, 71);
            this.lblNombreProv.Name = "lblNombreProv";
            this.lblNombreProv.Size = new System.Drawing.Size(87, 25);
            this.lblNombreProv.TabIndex = 14;
            this.lblNombreProv.Text = "Nombre:";
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Location = new System.Drawing.Point(24, 302);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(140, 50);
            this.btnLimpiarForm.TabIndex = 21;
            this.btnLimpiarForm.Text = "Limpiar Formulario";
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // lblTituloIns
            // 
            this.lblTituloIns.AutoSize = true;
            this.lblTituloIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIns.Location = new System.Drawing.Point(22, 18);
            this.lblTituloIns.Name = "lblTituloIns";
            this.lblTituloIns.Size = new System.Drawing.Size(248, 29);
            this.lblTituloIns.TabIndex = 12;
            this.lblTituloIns.Text = "Insertar un proveedor:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(166, 232);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(196, 22);
            this.txtTel.TabIndex = 20;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(166, 182);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(196, 22);
            this.txtDomicilio.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Domicilio:";
            // 
            // labelCamposError
            // 
            this.labelCamposError.AutoSize = true;
            this.labelCamposError.ForeColor = System.Drawing.Color.Crimson;
            this.labelCamposError.Location = new System.Drawing.Point(24, 272);
            this.labelCamposError.Name = "labelCamposError";
            this.labelCamposError.Size = new System.Drawing.Size(231, 17);
            this.labelCamposError.TabIndex = 26;
            this.labelCamposError.Text = "Todos los campos son obligatorios.";
            this.labelCamposError.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 371);
            this.Controls.Add(this.labelCamposError);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNombreError);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtCUIL);
            this.Controls.Add(this.txtBoxNombreProv);
            this.Controls.Add(this.lblCUIL);
            this.Controls.Add(this.lblNombreProv);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.lblTituloIns);
            this.Name = "Form3";
            this.Text = "Agregar un proveedor";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNombreError;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txtCUIL;
        private System.Windows.Forms.TextBox txtBoxNombreProv;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.Label lblNombreProv;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Label lblTituloIns;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCamposError;
    }
}