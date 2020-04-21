using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;

namespace DocentesApp
{
    public static class Core
    {
        //Variables Estaticas
        public static int tamano_barra_estado { get; } = 20;
        public static string nombre_archivo_sesion { get; } = "Sesion_Usuario";

        //Ajustar tamaños de pantalla
        public static int ScreenWidth { get; set; }
        public static int ScreenHeigth { get; set; }

        //Logica Para Validar Sesion
        public static int isLoggedin()
        {
            var session = Storage.getSession();
            if(session == null || string.IsNullOrEmpty(session.Codigo_Estudiante))
            {
                Console.WriteLine("Not logged in");
                return -1;
            }
            return -1;
        }
    }
}
