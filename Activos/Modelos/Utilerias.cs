using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;

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
        public static int? idSucursal;
        public static string nombre;
        public static string usuario;
        public static string empresa;

        public static bool admin;

        public static List<int> permisos;
    }

    public static class ConectionString
    {
        public static string conn { get; set; }
    }

    public static class Utilerias
    {
        // convierte en arreglo de bytes una imagen  en un PictureBox
        public static byte[] ImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();

            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bytes = ms.ToArray();

            ms.Dispose();

            return ms.ToArray();
        }

        // convierte una arreglo de bytes en imagen para poder mostrarla en un PictureBox
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        // valida si es ip una cadena
        public static bool esIp(string cadena)
        {
            bool result = false;

            Match match = Regex.Match(cadena, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

            if (match.Success) result = true;
                
                return result;
        }

        /// <summary>
        /// Performs the ROT13 character rotation.
        /// </summary>
        public static string Transform(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        // Codificar cadena a Base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        // Decodificar cadena a Base64
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        // Cálculo del dígito de control EAN
        public static string getCheckDigit(string barcode)
        {
            
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
