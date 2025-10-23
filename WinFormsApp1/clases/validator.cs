using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.clases
{
    public static class Validator
    {
        public static bool EsRequerido(string valor, string campo, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                mensaje = $"El campo {campo} es obligatorio.";
                return false;
            }
            mensaje = "";
            return true;
        }

        public static bool EsNumero(string valor, string campo, out string mensaje)
        {
            if (!long.TryParse(valor, out _))
            {
                mensaje = $"El campo {campo} debe ser numérico.";
                return false;
            }
            mensaje = "";
            return true;
        }

        public static bool EsLongitudMaxima(string valor, int max, string campo, out string mensaje)
        {
            if (valor.Length > max)
            {
                mensaje = $"El campo {campo} no puede tener más de {max} caracteres.";
                return false;
            }
            mensaje = "";
            return true;
        }

    }
}