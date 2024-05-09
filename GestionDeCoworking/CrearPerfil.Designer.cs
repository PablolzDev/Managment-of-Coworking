namespace GestionDeCoworking
{
    partial class frmCrearPerfil
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
            this.groupBoxTipoPerfil = new System.Windows.Forms.GroupBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkAdministrador = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.txtApellidoPerfil = new System.Windows.Forms.TextBox();
            this.txtIdentificacionPerfil = new System.Windows.Forms.TextBox();
            this.txtCorreoPerfil = new System.Windows.Forms.TextBox();
            this.txtContraseñaPerfil = new System.Windows.Forms.TextBox();
            this.btnAgregarPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipoPerfil.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTipoPerfil
            // 
            this.groupBoxTipoPerfil.Controls.Add(this.chkAdministrador);
            this.groupBoxTipoPerfil.Controls.Add(this.chkCliente);
            this.groupBoxTipoPerfil.Location = new System.Drawing.Point(223, 28);
            this.groupBoxTipoPerfil.Name = "groupBoxTipoPerfil";
            this.groupBoxTipoPerfil.Size = new System.Drawing.Size(323, 58);
            this.groupBoxTipoPerfil.TabIndex = 0;
            this.groupBoxTipoPerfil.TabStop = false;
            this.groupBoxTipoPerfil.Text = "Tipo de Perfil";
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(33, 21);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(70, 20);
            this.chkCliente.TabIndex = 0;
            this.chkCliente.Text = "Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.AutoSize = true;
            this.chkAdministrador.Location = new System.Drawing.Point(189, 21);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Size = new System.Drawing.Size(112, 20);
            this.chkAdministrador.TabIndex = 1;
            this.chkAdministrador.Text = "Administrador";
            this.chkAdministrador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContraseñaPerfil);
            this.groupBox1.Controls.Add(this.txtCorreoPerfil);
            this.groupBox1.Controls.Add(this.txtIdentificacionPerfil);
            this.groupBox1.Controls.Add(this.txtApellidoPerfil);
            this.groupBox1.Controls.Add(this.txtNombrePerfil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(223, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del perfil";
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Location = new System.Drawing.Point(170, 28);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(100, 22);
            this.txtNombrePerfil.TabIndex = 6;
            // 
            // txtApellidoPerfil
            // 
            this.txtApellidoPerfil.Location = new System.Drawing.Point(170, 71);
            this.txtApellidoPerfil.Name = "txtApellidoPerfil";
            this.txtApellidoPerfil.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoPerfil.TabIndex = 7;
            // 
            // txtIdentificacionPerfil
            // 
            this.txtIdentificacionPerfil.Location = new System.Drawing.Point(170, 113);
            this.txtIdentificacionPerfil.Name = "txtIdentificacionPerfil";
            this.txtIdentificacionPerfil.Size = new System.Drawing.Size(100, 22);
            this.txtIdentificacionPerfil.TabIndex = 8;
            // 
            // txtCorreoPerfil
            // 
            this.txtCorreoPerfil.Location = new System.Drawing.Point(170, 152);
            this.txtCorreoPerfil.Name = "txtCorreoPerfil";
            this.txtCorreoPerfil.Size = new System.Drawing.Size(100, 22);
            this.txtCorreoPerfil.TabIndex = 9;
            // 
            // txtContraseñaPerfil
            // 
            this.txtContraseñaPerfil.Location = new System.Drawing.Point(170, 191);
            this.txtContraseñaPerfil.Name = "txtContraseñaPerfil";
            this.txtContraseñaPerfil.Size = new System.Drawing.Size(100, 22);
            this.txtContraseñaPerfil.TabIndex = 10;
            // 
            // btnAgregarPerfil
            // 
            this.btnAgregarPerfil.Location = new System.Drawing.Point(308, 355);
            this.btnAgregarPerfil.Name = "btnAgregarPerfil";
            this.btnAgregarPerfil.Size = new System.Drawing.Size(153, 40);
            this.btnAgregarPerfil.TabIndex = 7;
            this.btnAgregarPerfil.Text = "Crear Perfil";
            this.btnAgregarPerfil.UseVisualStyleBackColor = true;
            // 
            // frmCrearPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarPerfil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTipoPerfil);
            this.Name = "frmCrearPerfil";
            this.Text = "CrearPerfil";
            this.groupBoxTipoPerfil.ResumeLayout(false);
            this.groupBoxTipoPerfil.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoPerfil;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContraseñaPerfil;
        private System.Windows.Forms.TextBox txtCorreoPerfil;
        private System.Windows.Forms.TextBox txtIdentificacionPerfil;
        private System.Windows.Forms.TextBox txtApellidoPerfil;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.Button btnAgregarPerfil;
    }
}