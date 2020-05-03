using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DocentesApp
{
    public class VistaMenuMaster : ContentPage
    {
        RelativeLayout VistaMenu;
        StackLayout Vista;
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
            //Vista = new StackLayout
            //{
            //    BackgroundColor = Colores.BarraNavegacion
            //};

            VistaMenu = new RelativeLayout
            {
                BackgroundColor = Colores.BarraNavegacion
            };

            listas = new BoxView
            {
                BackgroundColor = Colores.BLanco
            };

            //Items de la Lista
            Menu = new List<MasterMenu>
            {
                new MasterMenu { Titulo = "Registro Notas"},
                new MasterMenu { Titulo = "Listado Estudiantes"},
                new MasterMenu { Titulo = "Cerrar Sesion"}
            };

            //Instanciamos la lista
            listView = new ListView
            {
                ItemsSource = Menu,
                BackgroundColor = Colores.BLanco,
                ItemTemplate = new DataTemplate(typeof(EstiloTemplate)),
                SeparatorVisibility = SeparatorVisibility.None,          //Quitar lineas de separacion, si la quiero ve cambio el None por Default.
                //BackgroundColor = Colores.Color_CuadrosBlancos,
                RowHeight = 60                                        //Tamaño de celda

            };
        }
        void AgregarVistas()
        {
            VistaMenu.Children.Add(listView,
                Constraint.RelativeToParent((c) => { return 0; }),                       //X
                Constraint.RelativeToParent((c) => { return 200; }),                    //Y 
                Constraint.RelativeToParent((c) => { return 375; }),                    //W 
                Constraint.RelativeToParent((c) => { return 667; }));                           //H 

            Content = VistaMenu;
        }
        void AgregarEventos()
        {
            listView.ItemSelected += ListView_ItemSelected;
            listView.ItemTapped += ListView_ItemTapped;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;     //Casteo de "ListView". {Casteo = obligar a convertir el tipo de objeto}.
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            switch (((MasterMenu)e.Item).Titulo)
            {
                //Logica al dar tap.

                case "Registro Notas":

                    break;

                case "Listado Estudiantes":

                    break;


                case "Cerrar Sesion":
                    await DisplayAlert("Notificacion", "Sesión Finalizada", "Aceptar");
                    await Navigation.PushAsync(new Login());
                    break;

                default:
                    break;
            };
        }
    }
}
