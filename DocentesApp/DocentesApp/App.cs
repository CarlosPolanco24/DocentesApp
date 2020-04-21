using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocentesApp.Intefaces;
using Xamarin.Forms;

namespace DocentesApp
{
    public class App : Application
    {
        public static Sesion usuario;
        public App()
        {
            if(Core.isLoggedin() == 1)
            {
                usuario = Storage.getSession();
                //MainPage = new NavigationPage(new PaginaPricipal());
            }
            else
            {
                MainPage = new NavigationPage(new Login());
            }            
        }
    }
}