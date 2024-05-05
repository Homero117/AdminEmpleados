using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmpleados.BLL;
using AdminEmpleados.DAL;

namespace AdminEmpleados.PL
{
    
    public partial class FrmEmpleados : Form

       
    {
        EmpleadosDAL oEmpleadosDAL;

        byte[] imagenByte;
        public FrmEmpleados()
        {
            oEmpleadosDAL = new EmpleadosDAL();
            InitializeComponent();
            LLenarGridE();
            limpiarEntradas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentosDAL ojbDepartamentos = new DepartamentosDAL();
            cbx_Departamento.DataSource = ojbDepartamentos.MostrarDepartamentos().Tables[0];
            cbx_Departamento.DisplayMember = "departamentos";
            cbx_Departamento.ValueMember = "ID";

        }



        private void btn_Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog seleccionarimagen = new OpenFileDialog();

            seleccionarimagen.Title = "Seleccionar imagen";

            if ( seleccionarimagen.ShowDialog() == DialogResult.OK)
            {
                pic_Foto.Image = Image.FromStream(seleccionarimagen.OpenFile());

                MemoryStream memory = new MemoryStream();

                pic_Foto.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);


                imagenByte = memory.ToArray();
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.AgregarE(RecolectarDatos());
            LLenarGridE();
            limpiarEntradas();
        }

        private EmpleadoBLL RecolectarDatos() { 
            EmpleadoBLL objEmpleados = new EmpleadoBLL();

            int codigoEmpleado = 1;

            int.TryParse(txt_IDE.Text, out codigoEmpleado);

            objEmpleados.ID = codigoEmpleado;
            objEmpleados.Nombre = txt_NombreE.Text;
            objEmpleados.PrimerApellido = txt__PApellido.Text;
            objEmpleados.SegundoApellido = txt__SApellido.Text;
            objEmpleados.Correo = txt_Correo.Text;

            int IDDepartamento = 0;
            int.TryParse(cbx_Departamento.SelectedValue.ToString(), out IDDepartamento);

            objEmpleados.Departamento = IDDepartamento;

            objEmpleados.FotoEmpleado = imagenByte;

            return objEmpleados;
        }

        public void LLenarGridE()
        {

            dgv_Empleado.DataSource = oEmpleadosDAL.MostrarEmpleados().Tables[0];

            dgv_Empleado.Columns[0].HeaderText = "ID";
            dgv_Empleado.Columns[1].HeaderText = "Nombre Empleado";
            dgv_Empleado.Columns[2].HeaderText = "Primer Apellido";
            dgv_Empleado.Columns[3].HeaderText = "Segundo Apellido";
            dgv_Empleado.Columns[4].HeaderText = "Correo";
            dgv_Empleado.Columns[5].HeaderText = "Foto";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.ModificarE(RecolectarDatos());
            LLenarGridE();
            limpiarEntradas();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.EliminarE(RecolectarDatos());
            LLenarGridE();
            limpiarEntradas();
        }
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgv_Empleado.ClearSelection();

            if (indice >= 0)
            {
                txt_IDE.Text = dgv_Empleado.Rows[indice].Cells[0].Value.ToString();
                txt_NombreE.Text = dgv_Empleado.Rows[indice].Cells[1].Value.ToString();
                txt__PApellido.Text = dgv_Empleado.Rows[indice].Cells[2].Value.ToString();
                txt__SApellido.Text = dgv_Empleado.Rows[indice].Cells[3].Value.ToString();
                txt_Correo.Text = dgv_Empleado.Rows[indice].Cells[4].Value.ToString();
               
                object imagenCelda = dgv_Empleado.Rows[indice].Cells[5].Value;
                if (imagenCelda != null && imagenCelda != DBNull.Value)
                {
                    byte[] imageData = (byte[])imagenCelda;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pic_Foto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pic_Foto.Image = null;
                }

                btn_Agregar.Enabled = false;
                btn_Borrar.Enabled = true;
                btn_Cancelar.Enabled = true;
                btn_Modificar.Enabled = true;
            }
        }

        private void dgv_Empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void limpiarEntradas()
        {
            txt_IDE.Text = "";
            txt_NombreE.Text = "";
            txt__PApellido.Text = "";
            txt__SApellido.Text = "";
            txt_Correo.Text = "";
            pic_Foto.Image = null;

            btn_Agregar.Enabled = true;
            btn_Borrar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }

        private void pic_Foto_Click(object sender, EventArgs e)
        {

        }
    }

}