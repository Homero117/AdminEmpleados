namespace AdminEmpleados
{
    partial class FrmPrincipal
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
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.btn_Departamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.Image = global::AdminEmpleados.Properties.Resources._8666609_user_icon;
            this.btn_Empleado.Location = new System.Drawing.Point(711, 153);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(382, 313);
            this.btn_Empleado.TabIndex = 0;
            this.btn_Empleado.Text = "Empleado";
            this.btn_Empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Empleado.UseVisualStyleBackColor = true;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // btn_Departamento
            // 
            this.btn_Departamento.Image = global::AdminEmpleados.Properties.Resources._8666759_layers_layer_icon;
            this.btn_Departamento.Location = new System.Drawing.Point(93, 153);
            this.btn_Departamento.Name = "btn_Departamento";
            this.btn_Departamento.Size = new System.Drawing.Size(382, 313);
            this.btn_Departamento.TabIndex = 1;
            this.btn_Departamento.Text = "Departamento";
            this.btn_Departamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Departamento.UseVisualStyleBackColor = true;
            this.btn_Departamento.Click += new System.EventHandler(this.btn_Departamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 714);
            this.Controls.Add(this.btn_Departamento);
            this.Controls.Add(this.btn_Empleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.Button btn_Departamento;
    }
}

