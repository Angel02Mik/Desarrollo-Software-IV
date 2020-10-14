using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//0. Incluir una referencia a la capa DATOS
//1. Incorporar la biblioteca en nuestra clase
using DATOS;

namespace LOGICA
{
    //2. clase como PUBLIC
    public class Vehiculos
    {
        //3. Instancia de la clase de conexión
        DBAccess conexion = new DBAccess();

        //A partir de aquí, crearemos los métodos para todos los procesos que se requieran:
        //Insertar, listar, eliminar, verificar, buscar, editar, etc., etc.

        //Método #01: Listar Vehiculos (BD -> USUARIO)
        public DataTable listarVehiculos()
        {
            //Tipo objeto = new Clase();
            //DataTable     : contenedor de datos en formato XML (analogía sería como una tabla en la BD)
            //SqlDataAdapter: Adaptador (medio para transferir información)
            DataTable resultado = new DataTable();
            SqlDataAdapter adaptador = null;

            conexion.Conectar();
            adaptador = new SqlDataAdapter("SPUListarVehiculo", conexion.getConexion());
            adaptador.Fill(resultado);
            conexion.Desconectar();

            return resultado;
        }

        //Versión 1.0 (eliminar lógica (estado))
        public int eliminarVehiculo(int idvehiculo)
        {
            SqlCommand comando = new SqlCommand("SPUEliminarVehiculo", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            int filaAfectada = 0;

            conexion.Conectar();
            comando.Parameters.AddWithValue("@idvehiculo", idvehiculo);
            filaAfectada = comando.ExecuteNonQuery();
            conexion.Desconectar();

            return filaAfectada;
        }

        //Versión 1.0 (registrar)
        public int registrarVehiculo(string placa, string fabricacion, Int16 numero, string uso, 
                                     string categoria, int marca, string modelo, string numeroSerie, string color)
        {
            //Permite ejecutar el SPU enviándolo parámetros
            SqlCommand comando = new SqlCommand("SPURegistrarVehiculo", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            int registrado = 0;

            conexion.Conectar();

            //Sobrecargar el comando (envíandole los parámetros => SPU @variable)
            comando.Parameters.Add(new SqlParameter("@placa", placa));
            comando.Parameters.Add(new SqlParameter("@fabricacion",fabricacion));
            comando.Parameters.Add(new SqlParameter("@numero", numero));
            comando.Parameters.Add(new SqlParameter("@uso", uso));
            comando.Parameters.Add(new SqlParameter("@categoria", categoria));
            comando.Parameters.Add(new SqlParameter("@idmarca", marca));
            comando.Parameters.Add(new SqlParameter("@modelo", modelo));
            comando.Parameters.Add(new SqlParameter("@numeroSerie", numeroSerie));
            comando.Parameters.Add(new SqlParameter("@color", color));
            registrado = comando.ExecuteNonQuery();

            conexion.Desconectar();

            return registrado;
        }

    }
}
