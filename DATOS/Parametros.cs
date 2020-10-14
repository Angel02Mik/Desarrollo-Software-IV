using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    //Esta clase permitirá automatizar (mejorar) los procesos de CRUD
    //Servirá de apoyo a la clase DBAccess
    public class Parametros
    {
        //Procedimientos almacenados (programa que se ejecuta sobre SGBD)
        //ENTRADA (@Variables = ENTRADA | SALIDA) > PROCESO (Almacenamiento) > SALIDA (Respuestas)

        //Un parámetro en SQL requiere 5 atributos:
        //Nombre (@Apellidos), Valor ("FRANCIA"), TipoSQL (VARCHAR|String), Tamaño (30), Direccion (IN|OUTPUT)

        //Parámetros:
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccion { get; set; }

        //Constructores (método):
        //C1: Cuando el parámetro es de ENTRADA (IN)

        //Sobrecargas = valores|variables
        public Parametros(String nombre, Object valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
            this.Direccion = ParameterDirection.Input;  //ENTRADA
        }

        //C2: Cuando el parámetro es de SALIDA (OUTPUT)
        public Parametros(String nombre, SqlDbType tipodato, Int32 tamaño)
        {
            this.Nombre = nombre;
            this.TipoDato = tipodato;
            this.Tamaño = tamaño;
            this.Direccion = ParameterDirection.Output; //SALIDA
        }
    }
}
