namespace GestionDeCoworking
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblIDAdministrador = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtAdministrador = new System.Windows.Forms.TextBox();
            this.btnCrearPerfil = new System.Windows.Forms.Button();
            this.txtContraseñaCliente = new System.Windows.Forms.TextBox();
            this.txtContraseñaAdministrador = new System.Windows.Forms.TextBox();
            this.lblContraseñaCliente = new System.Windows.Forms.Label();
            this.lblContraseñaAdministrador = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxAdministrador = new System.Windows.Forms.GroupBox();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(303, 50);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(131, 16);
            this.lblSeleccion.TabIndex = 0;
            this.lblSeleccion.Text = "Selecciones su perfil";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(47, 35);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(64, 16);
            this.lblIDCliente.TabIndex = 1;
            this.lblIDCliente.Text = "ID Cliente";
            // 
            // lblIDAdministrador
            // 
            this.lblIDAdministrador.AutoSize = true;
            this.lblIDAdministrador.Location = new System.Drawing.Point(46, 35);
            this.lblIDAdministrador.Name = "lblIDAdministrador";
            this.lblIDAdministrador.Size = new System.Drawing.Size(106, 16);
            this.lblIDAdministrador.TabIndex = 2;
            this.lblIDAdministrador.Text = "ID Administrador";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(50, 80);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // txtAdministrador
            // 
            this.txtAdministrador.Location = new System.Drawing.Point(49, 80);
            this.txtAdministrador.Name = "txtAdministrador";
            this.txtAdministrador.Size = new System.Drawing.Size(100, 22);
            this.txtAdministrador.TabIndex = 4;
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.Location = new System.Drawing.Point(306, 349);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(128, 45);
            this.btnCrearPerfil.TabIndex = 5;
            this.btnCrearPerfil.Text = "Crear un perfil";
            this.btnCrearPerfil.UseVisualStyleBackColor = true;
            // 
            // txtContraseñaCliente
            // 
            this.txtContraseñaCliente.Location = new System.Drawing.Point(50, 186);
            this.txtContraseñaCliente.Name = "txtContraseñaCliente";
            this.txtContraseñaCliente.Size = new System.Drawing.Size(100, 22);
            this.txtContraseñaCliente.TabIndex = 6;
            // 
            // txtContraseñaAdministrador
            // 
            this.txtContraseñaAdministrador.Location = new System.Drawing.Point(49, 186);
            this.txtContraseñaAdministrador.Name = "txtContraseñaAdministrador";
            this.txtContraseñaAdministrador.Size = new System.Drawing.Size(100, 22);
            this.txtContraseñaAdministrador.TabIndex = 7;
            // 
            // lblContraseñaCliente
            // 
            this.lblContraseñaCliente.AutoSize = true;
            this.lblContraseñaCliente.Location = new System.Drawing.Point(47, 142);
            this.lblContraseñaCliente.Name = "lblContraseñaCliente";
            this.lblContraseñaCliente.Size = new System.Drawing.Size(76, 16);
            this.lblContraseñaCliente.TabIndex = 8;
            this.lblContraseñaCliente.Text = "Contraseña";
            // 
            // lblContraseñaAdministrador
            // 
            this.lblContraseñaAdministrador.AutoSize = true;
            this.lblContraseñaAdministrador.Location = new System.Drawing.Point(46, 142);
            this.lblContraseñaAdministrador.Name = "lblContraseñaAdministrador";
            this.lblContraseñaAdministrador.Size = new System.Drawing.Size(76, 16);
            this.lblContraseñaAdministrador.TabIndex = 9;
            this.lblContraseñaAdministrador.Text = "Contraseña";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.lblIDCliente);
            this.groupBoxCliente.Controls.Add(this.txtCliente);
            this.groupBoxCliente.Controls.Add(this.lblContraseñaCliente);
            this.groupBoxCliente.Controls.Add(this.txtContraseñaCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(135, 103);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(200, 229);
            this.groupBoxCliente.TabIndex = 10;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // groupBoxAdministrador
            // 
            this.groupBoxAdministrador.Controls.Add(this.lblIDAdministrador);
            this.groupBoxAdministrador.Controls.Add(this.txtAdministrador);
            this.groupBoxAdministrador.Controls.Add(this.lblContraseñaAdministrador);
            this.groupBoxAdministrador.Controls.Add(this.txtContraseñaAdministrador);
            this.groupBoxAdministrador.Location = new System.Drawing.Point(424, 103);
            this.groupBoxAdministrador.Name = "groupBoxAdministrador";
            this.groupBoxAdministrador.Size = new System.Drawing.Size(206, 229);
            this.groupBoxAdministrador.TabIndex = 11;
            this.groupBoxAdministrador.TabStop = false;
            this.groupBoxAdministrador.Text = "Administrador";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAdministrador);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.btnCrearPerfil);
            this.Controls.Add(this.lblSeleccion);
            this.Name = "frmInicio";
            this.Text = "Iniciar";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxAdministrador.ResumeLayout(false);
            this.groupBoxAdministrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblIDAdministrador;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtAdministrador;
        private System.Windows.Forms.Button btnCrearPerfil;
        private System.Windows.Forms.TextBox txtContraseñaCliente;
        private System.Windows.Forms.TextBox txtContraseñaAdministrador;
        private System.Windows.Forms.Label lblContraseñaCliente;
        private System.Windows.Forms.Label lblContraseñaAdministrador;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBoxAdministrador;
    }
}

