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
    internal class EmpleadosDAL
    {
        ConexionDAL conexionDAL;


        public EmpleadosDAL()
        {
            conexionDAL = new ConexionDAL();
        }

        public bool AgregarE(EmpleadoBLL oEmpleadoBLL) {

            // Crear el comando SQL para insertar un nuevo registro en la tabla de empleados
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Empleados (nombres, primerApellido, segundoApellido, correo, foto) VALUES(@Nombres, @PrimerApellido, @SegundoApellido, @Correo, @Foto)");

            // Agregar parámetros al comando SQL para cada campo del empleado
            sqlCommand.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = oEmpleadoBLL.Nombre;
            sqlCommand.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = oEmpleadoBLL.PrimerApellido;
            sqlCommand.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = oEmpleadoBLL.SegundoApellido;
            sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar).Value = oEmpleadoBLL.Correo;
            sqlCommand.Parameters.Add("@Foto", SqlDbType.Image).Value = oEmpleadoBLL.FotoEmpleado;

            // Ejecutar el comando SQL y devolver el resultado
            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public bool EliminarE(EmpleadoBLL oEmpleadoBLL)
        {
            // Crear el comando SQL para eliminar el registro del empleado
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Empleados WHERE id=@ID");
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = oEmpleadoBLL.ID;

            // Ejecutar el comando SQL y devolver el resultado
            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }
        public bool ModificarE(EmpleadoBLL oEmpleadoBLL)
        {
            // Crear el comando SQL para actualizar el registro del empleado
            SqlCommand sqlCommand = new SqlCommand("UPDATE Empleados SET nombres=@Nombres, primerApellido=@PrimerApellido, segundoApellido=@SegundoApellido, correo=@Correo, foto=@Foto WHERE id=@ID");

            // Agregar parámetros al comando SQL para cada campo del empleado
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = oEmpleadoBLL.ID;
            sqlCommand.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = oEmpleadoBLL.Nombre;
            sqlCommand.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = oEmpleadoBLL.PrimerApellido;
            sqlCommand.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = oEmpleadoBLL.SegundoApellido;
            sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar).Value = oEmpleadoBLL.Correo;
            sqlCommand.Parameters.Add("@Foto", SqlDbType.Image).Value = oEmpleadoBLL.FotoEmpleado;

            // Ejecutar el comando SQL y devolver el resultado
            return conexionDAL.EjecutarComandoSinRetornoDatos(sqlCommand);
        }

        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");
            return conexionDAL.EjecutarSentencia(sentencia);
        }
    }
}
