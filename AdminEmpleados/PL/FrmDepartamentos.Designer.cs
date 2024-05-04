namespace AdminEmpleados.PL
{
    partial class FrmDepartamentos
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
            this.txt_ID_D = new System.Windows.Forms.TextBox();
            this.txt_Departamento = new System.Windows.Forms.TextBox();
            this.lbl_ID_D = new System.Windows.Forms.Label();
            this.lbl_Departamento = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dgv_Departamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Departamento)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID_D
            // 
            this.txt_ID_D.Location = new System.Drawing.Point(102, 99);
            this.txt_ID_D.Name = "txt_ID_D";
            this.txt_ID_D.ReadOnly = true;
            this.txt_ID_D.Size = new System.Drawing.Size(266, 31);
            this.txt_ID_D.TabIndex = 0;
            this.txt_ID_D.TextChanged += new System.EventHandler(this.txt_ID_D_TextChanged);
            // 
            // txt_Departamento
            // 
            this.txt_Departamento.Location = new System.Drawing.Point(402, 99);
            this.txt_Departamento.Name = "txt_Departamento";
            this.txt_Departamento.Size = new System.Drawing.Size(525, 31);
            this.txt_Departamento.TabIndex = 1;
            this.txt_Departamento.TextChanged += new System.EventHandler(this.txt_Departamento_TextChanged);
            // 
            // lbl_ID_D
            // 
            this.lbl_ID_D.AutoSize = true;
            this.lbl_ID_D.Location = new System.Drawing.Point(102, 68);
            this.lbl_ID_D.Name = "lbl_ID_D";
            this.lbl_ID_D.Size = new System.Drawing.Size(38, 25);
            this.lbl_ID_D.TabIndex = 2;
            this.lbl_ID_D.Text = "ID:";
            // 
            // lbl_Departamento
            // 
            this.lbl_Departamento.AutoSize = true;
            this.lbl_Departamento.Location = new System.Drawing.Point(397, 71);
            this.lbl_Departamento.Name = "lbl_Departamento";
            this.lbl_Departamento.Size = new System.Drawing.Size(147, 25);
            this.lbl_Departamento.TabIndex = 3;
            this.lbl_Departamento.Text = "Departamento";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = global::AdminEmpleados.Properties.Resources._8666650_file_plus_icon;
            this.btn_Agregar.Location = new System.Drawing.Point(102, 148);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(178, 76);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::AdminEmpleados.Properties.Resources._8666806_edit_write_pen_icon;
            this.btn_Modificar.Location = new System.Drawing.Point(318, 148);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(178, 76);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Image = global::AdminEmpleados.Properties.Resources._8666597_trash_2_icon;
            this.btn_Borrar.Location = new System.Drawing.Point(530, 148);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(178, 76);
            this.btn_Borrar.TabIndex = 6;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::AdminEmpleados.Properties.Resources._8666740_slash_icon;
            this.btn_Cancelar.Location = new System.Drawing.Point(741, 148);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(178, 76);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dgv_Departamento
            // 
            this.dgv_Departamento.AllowUserToAddRows = false;
            this.dgv_Departamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Departamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Departamento.Location = new System.Drawing.Point(102, 262);
            this.dgv_Departamento.Name = "dgv_Departamento";
            this.dgv_Departamento.RowHeadersWidth = 82;
            this.dgv_Departamento.RowTemplate.Height = 33;
            this.dgv_Departamento.Size = new System.Drawing.Size(825, 460);
            this.dgv_Departamento.TabIndex = 8;
            this.dgv_Departamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Departamento_CellContentClick);
            this.dgv_Departamento.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 756);
            this.Controls.Add(this.dgv_Departamento);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Departamento);
            this.Controls.Add(this.lbl_ID_D);
            this.Controls.Add(this.txt_Departamento);
            this.Controls.Add(this.txt_ID_D);
            this.Name = "FrmDepartamentos";
            this.Text = "FrmDepartamentos";
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Departamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID_D;
        private System.Windows.Forms.TextBox txt_Departamento;
        private System.Windows.Forms.Label lbl_ID_D;
        private System.Windows.Forms.Label lbl_Departamento;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dgv_Departamento;
    }
}