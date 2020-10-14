using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Primero necesitamos importar las librerías
using System.Data;              //DataTable
using System.Data.SqlClient;    //SGBD al cual nos conectamos (MS SQL Server)

namespace DATOS
{
    //2. Especificar nuestra clase en visibilidad pública
    public class DBAccess
    {
        //3. Crear un atributo/objeto de conexión
        //Observaciones, como se trata de una conexión local, no requiero USERID - PASSWORD
        private SqlConnection conexion = new SqlConnection("data source=.; database=SOAT; integrated security=true");

        //4. Método de acceso:

        //4.1. Método que retorne la conexión (servidor, base de datos, usuario, clave, seguridad)
        public SqlConnection getConexion()
        {
            return conexion;
        }

        //Entorno de desarrollo: DESCONECTADO
        //4.2. Abrir la conexión
        public void Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }

        //4.3. Cerrar la conexión
        public void Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        //CREAMOS LOS MÉTODOS PARA AUTOMATIZAR EL CRUD (CREATE-READ-UPDATE-DELETE)

        //READ (Este método simplifica al 90% todos los futuros métodos de LISTAR|BÚSQUEDA)
        //ListarMarcas, ListarVehiculos, ListarEmpresas, ListarDistritos(String idProvincia)

        /**
         * Este método permite automatizar cualquier proceso de listado o búsqueda de procesos del sistema
         */
        public DataTable Listar(String nombreSPU, List<Parametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adaptador;

            try
            {
                Conectar();
                adaptador = new SqlDataAdapter(nombreSPU, conexion);
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                //¿Cuántos parámetros tengo?
                if (lst != null)
                {
                    //Si no está vacía, tengo que recoger esos parámetros y añadirlos a la transacción
                    for (int i = 0; i < lst.Count; i++)
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        //comando.Parameters.AddWithValue("@idprovincia", "PROV00000015");
                    }
                }

                //Retornando resultados
                adaptador.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }

            Desconectar();

            return dt;
        }

    }
}
