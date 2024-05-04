using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AdminEmpleados.BLL;

namespace AdminEmpleados.DAL
{
    internal class DepartamentosDAL
    {
        ConexionDAL conexionDAL;

        public DepartamentosDAL() {
            conexionDAL = new ConexionDAL();
        }

        public bool Agregar(DepartamentoBLL oDepartamentoBLL)
        {
            SqlCommand SQLComando = new SqlCommand("INSERT INTO departamento VALUES(@Departamento) ");

            SQLComando.Parameters.Add("@Departamento",SqlDbType.VarChar).Value = oDepartamentoBLL.Departamento;

            return conexionDAL.EjecutarComandoSinRetornoDatos(SQLComando);  

          ///  return conexionDAL.EjecutarComandoSinRetornoDatos("INSERT INTO departamento (departamentos) VALUES('"+ oDepartamentoBLL.Departamento + "')");
         
        }
        public bool Eliminar(DepartamentoBLL oDepartamentoBLL) {

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM departamento WHERE id=@ID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentoBLL.ID;

            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand); 
           // conexionDAL.EjecutarComandoSinRetornoDatos("DELETE FROM departamento WHERE id=" + oDepartamentoBLL.ID);

           // return 1;

        }
        public bool Modificar(DepartamentoBLL oDepartamentoBLL)
        {
            SqlCommand command = new SqlCommand("UPDATE departamento SET departamentos =@Departamento WHERE ID =@ID");
            command.Parameters.Add("@Departamento", SqlDbType.VarChar  ).Value= oDepartamentoBLL.Departamento;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentoBLL.ID;

            return conexionDAL.EjecutarComandoSinRetornoDatos(command);

            /* conexionDAL.EjecutarComandoSinRetornoDatos("UPDATE departamento " +
                 "SET departamentos = '"+oDepartamentoBLL.Departamento+"'" +
                 " WHERE id=" + oDepartamentoBLL.ID);

             return 1; */

        }


        public DataSet MostrarDepartamentos() {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM departamento");
            return conexionDAL.EjecutarSentencia (sentencia);   
        }
    }
}
