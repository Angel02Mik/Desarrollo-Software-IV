using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DATOS;

namespace LOGICA
{
    public class Marcas
    {
        DBAccess conexion = new DBAccess();

        public DataTable listarMarcas()
        {
            DataTable resultado = new DataTable();
            conexion.Conectar();
            SqlDataAdapter adaptador = new SqlDataAdapter("SPUListarMarca", conexion.getConexion());
            adaptador.Fill(resultado);
            conexion.Desconectar();

            return resultado;
        }

        public DataTable listarMarcasV2()
        {
            //Parámetro
            return conexion.Listar("SPUListarMarca", null);
        }
    }
}
