namespace AdminEmpleados.PL
{
    partial class FrmEmpleados
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
            this.dgv_Empleado = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Examinar = new System.Windows.Forms.Button();
            this.lbl_Departamento = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl__SApellido = new System.Windows.Forms.Label();
            this.lbl_PApellido = new System.Windows.Forms.Label();
            this.lbl_Nombre_E = new System.Windows.Forms.Label();
            this.lbl_ID_E = new System.Windows.Forms.Label();
            this.pic_Foto = new System.Windows.Forms.PictureBox();
            this.cbx_Departamento = new System.Windows.Forms.ComboBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt__SApellido = new System.Windows.Forms.TextBox();
            this.txt__PApellido = new System.Windows.Forms.TextBox();
            this.txt_NombreE = new System.Windows.Forms.TextBox();
            this.txt_IDE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Empleado
            // 
            this.dgv_Empleado.AllowUserToAddRows = false;
            this.dgv_Empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleado.Location = new System.Drawing.Point(215, 488);
            this.dgv_Empleado.Name = "dgv_Empleado";
            this.dgv_Empleado.RowHeadersWidth = 82;
            this.dgv_Empleado.RowTemplate.Height = 33;
            this.dgv_Empleado.Size = new System.Drawing.Size(1194, 271);
            this.dgv_Empleado.TabIndex = 37;
            this.dgv_Empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleado_CellContentClick);
            this.dgv_Empleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::AdminEmpleados.Properties.Resources._8666740_slash_icon;
            this.btn_Cancelar.Location = new System.Drawing.Point(1218, 382);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(178, 76);
            this.btn_Cancelar.TabIndex = 36;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Image = global::AdminEmpleados.Properties.Resources._8666597_trash_2_icon;
            this.btn_Borrar.Location = new System.Drawing.Point(1026, 382);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(178, 76);
            this.btn_Borrar.TabIndex = 35;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::AdminEmpleados.Properties.Resources._8666806_edit_write_pen_icon;
            this.btn_Modificar.Location = new System.Drawing.Point(833, 382);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(178, 76);
            this.btn_Modificar.TabIndex = 34;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::AdminEmpleados.Properties.Resources._8666650_file_plus_icon;
            this.btn_Agregar.Location = new System.Drawing.Point(642, 382);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(178, 76);
            this.btn_Agregar.TabIndex = 33;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Examinar
            // 
            this.btn_Examinar.Image = global::AdminEmpleados.Properties.Resources._8666659_image_icon;
            this.btn_Examinar.Location = new System.Drawing.Point(215, 382);
            this.btn_Examinar.Name = "btn_Examinar";
            this.btn_Examinar.Size = new System.Drawing.Size(358, 76);
            this.btn_Examinar.TabIndex = 32;
            this.btn_Examinar.Text = "Examinar";
            this.btn_Examinar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Examinar.UseVisualStyleBackColor = true;
            this.btn_Examinar.Click += new System.EventHandler(this.btn_Examinar_Click);
            // 
            // lbl_Departamento
            // 
            this.lbl_Departamento.AutoSize = true;
            this.lbl_Departamento.Location = new System.Drawing.Point(637, 297);
            this.lbl_Departamento.Name = "lbl_Departamento";
            this.lbl_Departamento.Size = new System.Drawing.Size(153, 25);
            this.lbl_Departamento.TabIndex = 31;
            this.lbl_Departamento.Text = "Departamento:";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(637, 220);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(83, 25);
            this.lbl_Correo.TabIndex = 30;
            this.lbl_Correo.Text = "Correo:";
            // 
            // lbl__SApellido
            // 
            this.lbl__SApellido.AutoSize = true;
            this.lbl__SApellido.Location = new System.Drawing.Point(952, 146);
            this.lbl__SApellido.Name = "lbl__SApellido";
            this.lbl__SApellido.Size = new System.Drawing.Size(187, 25);
            this.lbl__SApellido.TabIndex = 29;
            this.lbl__SApellido.Text = "Segundo Apellido:";
            // 
            // lbl_PApellido
            // 
            this.lbl_PApellido.AutoSize = true;
            this.lbl_PApellido.Location = new System.Drawing.Point(637, 146);
            this.lbl_PApellido.Name = "lbl_PApellido";
            this.lbl_PApellido.Size = new System.Drawing.Size(163, 25);
            this.lbl_PApellido.TabIndex = 28;
            this.lbl_PApellido.Text = "Primer Apellido:";
            // 
            // lbl_Nombre_E
            // 
            this.lbl_Nombre_E.AutoSize = true;
            this.lbl_Nombre_E.Location = new System.Drawing.Point(837, 62);
            this.lbl_Nombre_E.Name = "lbl_Nombre_E";
            this.lbl_Nombre_E.Size = new System.Drawing.Size(87, 25);
            this.lbl_Nombre_E.TabIndex = 27;
            this.lbl_Nombre_E.Text = "Nombre";
            // 
            // lbl_ID_E
            // 
            this.lbl_ID_E.AutoSize = true;
            this.lbl_ID_E.Location = new System.Drawing.Point(637, 59);
            this.lbl_ID_E.Name = "lbl_ID_E";
            this.lbl_ID_E.Size = new System.Drawing.Size(38, 25);
            this.lbl_ID_E.TabIndex = 26;
            this.lbl_ID_E.Text = "ID:";
            this.lbl_ID_E.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic_Foto
            // 
            this.pic_Foto.Location = new System.Drawing.Point(215, 62);
            this.pic_Foto.Name = "pic_Foto";
            this.pic_Foto.Size = new System.Drawing.Size(358, 296);
            this.pic_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Foto.TabIndex = 25;
            this.pic_Foto.TabStop = false;
            this.pic_Foto.Click += new System.EventHandler(this.pic_Foto_Click);
            // 
            // cbx_Departamento
            // 
            this.cbx_Departamento.FormattingEnabled = true;
            this.cbx_Departamento.Location = new System.Drawing.Point(637, 325);
            this.cbx_Departamento.Name = "cbx_Departamento";
            this.cbx_Departamento.Size = new System.Drawing.Size(759, 33);
            this.cbx_Departamento.TabIndex = 24;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(637, 248);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(759, 31);
            this.txt_Correo.TabIndex = 23;
            // 
            // txt__SApellido
            // 
            this.txt__SApellido.Location = new System.Drawing.Point(957, 174);
            this.txt__SApellido.Name = "txt__SApellido";
            this.txt__SApellido.Size = new System.Drawing.Size(439, 31);
            this.txt__SApellido.TabIndex = 22;
            // 
            // txt__PApellido
            // 
            this.txt__PApellido.Location = new System.Drawing.Point(637, 174);
            this.txt__PApellido.Name = "txt__PApellido";
            this.txt__PApellido.Size = new System.Drawing.Size(295, 31);
            this.txt__PApellido.TabIndex = 21;
            // 
            // txt_NombreE
            // 
            this.txt_NombreE.Location = new System.Drawing.Point(833, 90);
            this.txt_NombreE.Name = "txt_NombreE";
            this.txt_NombreE.Size = new System.Drawing.Size(563, 31);
            this.txt_NombreE.TabIndex = 20;
            // 
            // txt_IDE
            // 
            this.txt_IDE.Enabled = false;
            this.txt_IDE.Location = new System.Drawing.Point(637, 90);
            this.txt_IDE.Name = "txt_IDE";
            this.txt_IDE.Size = new System.Drawing.Size(171, 31);
            this.txt_IDE.TabIndex = 19;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 777);
            this.Controls.Add(this.dgv_Empleado);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Examinar);
            this.Controls.Add(this.lbl_Departamento);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl__SApellido);
            this.Controls.Add(this.lbl_PApellido);
            this.Controls.Add(this.lbl_Nombre_E);
            this.Controls.Add(this.lbl_ID_E);
            this.Controls.Add(this.pic_Foto);
            this.Controls.Add(this.cbx_Departamento);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt__SApellido);
            this.Controls.Add(this.txt__PApellido);
            this.Controls.Add(this.txt_NombreE);
            this.Controls.Add(this.txt_IDE);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Empleado;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Examinar;
        private System.Windows.Forms.Label lbl_Departamento;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl__SApellido;
        private System.Windows.Forms.Label lbl_PApellido;
        private System.Windows.Forms.Label lbl_Nombre_E;
        private System.Windows.Forms.Label lbl_ID_E;
        private System.Windows.Forms.PictureBox pic_Foto;
        private System.Windows.Forms.ComboBox cbx_Departamento;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt__SApellido;
        private System.Windows.Forms.TextBox txt__PApellido;
        private System.Windows.Forms.TextBox txt_NombreE;
        private System.Windows.Forms.TextBox txt_IDE;
    }
}