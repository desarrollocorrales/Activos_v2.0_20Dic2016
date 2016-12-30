using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Activos.Modelos
{
    public enum Estatus
    {
        OK, ERROR
    }

    public partial class Response
    {
        public Estatus status { get; set; }
        public string resultado { get; set; }
        public string error { get; set; }
        public Modelos.Usuarios usuario { get; set; }
    }

    public static class Login
    {
        public static int idUsuario;
        public static string nombre;
        public static string usuario;
    }


    public static class Utilerias
    {
        public static string getCheckDigit(string barcode)
        {
            // Cálculo del dígito de control EAN
            int iSum = 0;
            int iSumInpar = 0;
            int iDigit = 0;
            string EAN = barcode;

            EAN = EAN.PadLeft(13, '0');

            for (int i = EAN.Length; i >= 1; i--)
            {
                iDigit = Convert.ToInt32(EAN.Substring(i - 1, 1));
                if (i % 2 != 0)
                {
                    iSumInpar += iDigit;
                }
                else
                {
                    iSum += iDigit;
                }
            }

            iDigit = (iSumInpar * 3) + iSum;

            int iCheckSum = (10 - (iDigit % 10)) % 10;
            return iCheckSum.ToString();
        }

        /// <summary>
        /// Ejecuta una sql que rellenar un DataReader (sentencia select).
        /// </summary>
        /// <param name="SqlQuery">sentencia sql a ejecutar</param>
        /// <returns>Estatus de transacción y datos obtenidos</returns> 
        public static ManejoSql EjecutaSQL(string SqlQuery, MySqlCommand cmd)
        {
            ManejoSql result = new ManejoSql();

            try
            {
                // Se define el tipo de comando
                cmd.CommandType = CommandType.Text;

                // Se define la instruccion Transact-SQL 
                cmd.CommandText = SqlQuery;

                // Ejecutamos sql.
                result.reader = cmd.ExecuteReader();

                // Se define si la respuesta no generó ningun error
                result.ok = true;

            }
            catch (MySqlException sqlex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = sqlex.Number;

                // Se define el mensaje de error
                result.descErr = sqlex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }
            catch (Exception ex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = 0;

                // Se define el mensaje de error
                result.descErr = ex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }

            return result;
        }


        /// <summary>
        /// Ejecuta una sql que no devuelve datos (update, delete, insert).
        /// </summary>
        /// <param name="SqlQuery">sentencia sql a ejecutar</param>
        /// <param name="FilasAfectadas">Fila afectadas por la sentencia SQL</param>
        /// <returns></returns>
        public static ManejoSql EjecutaSQL(string SqlQuery, ref int FilasAfectadas, MySqlCommand cmd)
        {
            ManejoSql result = new ManejoSql();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;

                // regresa las filas afectadas
                FilasAfectadas = cmd.ExecuteNonQuery();

                result.ok = true;
            }
            catch (MySqlException sqlex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = sqlex.Number;

                // Se define el mensaje de error
                result.descErr = sqlex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }
            catch (Exception ex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = 0;

                // Se define el mensaje de error
                result.descErr = ex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }

            return result;
        }
    }
}
