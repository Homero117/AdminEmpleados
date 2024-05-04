using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AdminEmpleados.DAL;
using AdminEmpleados.BLL;

namespace AdminEmpleados.PL
{
    public partial class FrmDepartamentos : Form
    {
        DepartamentosDAL oDepartamentosDAL;
        public FrmDepartamentos()
        {
            oDepartamentosDAL = new DepartamentosDAL();
            InitializeComponent();
            LLenarGrid();
            limpiarEntradas();
        }



        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
                       
            oDepartamentosDAL.Agregar(RecuperarInfo());
            LLenarGrid();
            limpiarEntradas();


        }

        private DepartamentoBLL RecuperarInfo()
        {
            DepartamentoBLL oDepartamentoBLL = new DepartamentoBLL();
            int ID = 0; int.TryParse(txt_ID_D.Text, out ID);
            oDepartamentoBLL.ID = ID;

            oDepartamentoBLL.Departamento = txt_Departamento.Text;

            return oDepartamentoBLL;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgv_Departamento.ClearSelection();

            if (indice >=0 ) {
                txt_ID_D.Text = dgv_Departamento.Rows[indice].Cells[0].Value.ToString();
                txt_Departamento.Text = dgv_Departamento.Rows[indice].Cells[1].Value.ToString();

                btn_Agregar.Enabled = false;
                btn_Borrar.Enabled = true;
                btn_Cancelar.Enabled = true;
                btn_Modificar.Enabled = true;
            }
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Eliminar(RecuperarInfo());
            LLenarGrid();
            limpiarEntradas();


        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Modificar(RecuperarInfo());
            LLenarGrid();
            limpiarEntradas();

        }

        public void LLenarGrid() {

            dgv_Departamento.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];

            dgv_Departamento.Columns[0].HeaderText = "ID";
            dgv_Departamento.Columns[1].HeaderText = "Nombre de Departamento";

        }

        public void limpiarEntradas()
        {
            txt_ID_D.Text = "";
            txt_Departamento.Text = "";
            btn_Agregar.Enabled = true;
            btn_Borrar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Modificar.Enabled = false;


        }

        private void txt_ID_D_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }

        private void txt_Departamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Departamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
