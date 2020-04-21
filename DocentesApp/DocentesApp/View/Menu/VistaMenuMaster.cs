using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DocentesApp.View.Menu
{
    public class VistaMenuMaster : ContentPage
    {
        RelativeLayout Vista;
        List<MasterMenu> Menu;
        ListView listView;
        BoxView listas;
        public VistaMenuMaster()
        {
            Title = "Bienvenido";
            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }

        void CrearVistas()
        {
            Vista = new RelativeLayout
            {
                BackgroundColor = Colores.BarraNavegacion
            };

            listas = new BoxView
            {
                BackgroundColor = Color.White
            };

        }
        void AgregarVistas()
        {

        }
        void AgregarEventos()
        {

        }
    }
}
