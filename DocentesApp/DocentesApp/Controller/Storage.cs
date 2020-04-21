using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using DocentesApp;
using DocentesApp.Intefaces;
using Xamarin.Forms;

namespace DocentesApp
{
    public static class Storage
    {
        public static Sesion getSession()
        {
            bool exist = DependencyService.Get<IFileManager>().exist(Core.nombre_archivo_sesion);
            if (exist)
            {
                var sessionJson = DependencyService.Get<IFileManager>().LoadText(Core.nombre_archivo_sesion);

                try
                {
                    return JsonConvert.DeserializeObject<Sesion>(sessionJson);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error parsing Session from disk:" + e.Message);
                    //deleteSession();
                    return null;
                };
            }
            else
            {
                Console.WriteLine("No Sesion Stored");
                return null;
            }
        }




    }
}
