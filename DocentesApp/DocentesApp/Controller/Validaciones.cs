using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DocentesApp
{
    public class Validaciones
    {
        //Validacion Numero de Documento
        public bool ValidarNumeroDocumento(Entry documento)
        {
            if (string.IsNullOrEmpty(documento.Text))
            {
                return true;
            }
            else
                return false;
        }
        public bool ValidarTamanoNumeroDocumento(Entry documento)
        {
            if (documento.Text.Length == 10)
                return true;
            else
                return false;
        }
        public bool ValidarDocumentoNumerico(Entry documento)
        {
            if (string.IsNullOrEmpty(documento.Text))
            {
                return true;
            }
            //Valida que solo se ingresen numeros
            if (!documento.Text.ToCharArray().All(Char.IsDigit))
            {
                return true;
            }
            else
                return false;
        }

        //Validacion Codigo Estudiante
        public bool ValidarCodigoEstudiante(Entry codigo)
        {
            if (string.IsNullOrEmpty(codigo.Text))
            {
                return true;
            }
            else
                return false;
        }
        public bool ValidarCodigoEstudianteNumerico(Entry codigo)
        {
            //Valida que solo se ingresen numeros
            if (!codigo.Text.ToCharArray().All(Char.IsDigit))
            {
                return true;
            }
            else
                return false;
        }

        //Validar Contraseña
        public bool ValidarCajasTextoContraseña(Entry password)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                return true;
            }
            else
                return false;
        }

        //Validar Contraseña de 8 digitos
        public bool ValidarCampoContraseñas(Entry password)
        {
            if (password.Text.Length >= 8)
                return true;
            else
                return false;
        }
    }
}
