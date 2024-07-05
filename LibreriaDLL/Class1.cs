using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaDLL
{
    public class Biblioteca 
    {
        public static DataSet Herramientas(string cmd)
        {
            SqlConnection conexion = new SqlConnection("Data Source=IVAN\\SQLEXPRES;Initial Catalog=Sistema_Trinipan;Integrated Security=True;Encrypt=False");
            conexion.Open();

            DataSet dll = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conexion);

            adapter.Fill(dll);

            conexion.Close();

            return dll;
        }

        public static Boolean ValidarFormulario(Control ObjetoError, ErrorProvider ErrorProvider)
        {
            Boolean SiError = false;

            foreach (Control campo in ObjetoError.Controls)
            {
                if (campo is ErrorTexBox objeto)
                {
                    if (objeto.Validar == true)
                    {
                        if (string.IsNullOrEmpty(objeto.Text.Trim()))
                        {
                            ErrorProvider.SetError(objeto, "Los campos no pueden estar vacios");
                            SiError = true;
                        }
                    }
                    if (objeto.ValidarNumeros == true)
                    {
                        int contador = 0, EncontrarLetras = 0;

                        foreach (char letra in objeto.Text.Trim())
                        {
                            if (char.IsLetter(objeto.Text.Trim(), contador))
                            {
                                EncontrarLetras++;
                            }
                            contador++;
                        }

                        if (EncontrarLetras != 0)
                        {
                            SiError = true;
                            ErrorProvider.SetError(objeto, "Solo se aceptan numeros");
                        }
                    }
                    if (objeto.ValidarCorreo == true)
                    {
                        if (!EsEmailValido(objeto.Text.Trim()))
                        {
                            SiError = true;
                            ErrorProvider.SetError(objeto, "Correo electrónico no válido");
                        }
                    }
                }
            }
            return SiError;
        }
        private static bool EsEmailValido(string email)
        {
            // Expresión regular para validar correos electrónicos
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }
    }
}
