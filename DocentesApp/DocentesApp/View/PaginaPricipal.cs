using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DocentesApp
{
    public class PaginaPricipal : ContentPage
    {
        List<string> MiListaEstudiantil;
        ObservableCollection<string> MiListaEstudiantil2;
        SearchBar miControlDeBusqueda;

        ListView lista1;

        Image Agregar;

        RelativeLayout contenedorPrincipal;

        StackLayout vistaGeneral;

        TapGestureRecognizer botonAgregar;

        Cargando loading;

        //BoxView navegacion;

        //PaginaPricipal test;
        public PaginaPricipal()
        {
            Title = "       Pagina Principal";
            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }

        void CrearVistas()
        {
            loading = new Cargando();

            //navegacion = new BoxView
            //{
            //    BackgroundColor = Colores.BarraNavegacion
            //};

            MiListaEstudiantil = new List<string>();

            MiListaEstudiantil2 = new ObservableCollection<string>();
            LlenadoDeEstudiantesQuemados();

            miControlDeBusqueda = new SearchBar
            {
                Placeholder = "Agregar Nombre",
                PlaceholderColor = Colores.Principal,
                TextColor = Color.Black,
                //MaxLength = 10
            };           

            lista1 = new ListView
            {
                BackgroundColor = Color.Transparent,
                ItemsSource = MiListaEstudiantil2
            };

            Agregar = new Image
            {
                Source = Imagenes.BotonMas
            };                      

            vistaGeneral = new StackLayout();

            contenedorPrincipal = new RelativeLayout 
            {
                BackgroundColor = Color.White
            };

            botonAgregar = new TapGestureRecognizer();
            Agregar.GestureRecognizers.Add(botonAgregar);
            
        }

        void AgregarVistas()
        {
            //contenedorPrincipal.Children.Add(navegacion,
            //    Constraint.RelativeToParent((c) => { return 0; }),                                      //X
            //    Constraint.RelativeToParent((c) => { return 0; }),                                      //Y
            //    Constraint.RelativeToParent((c) => { return c.Width; }),                                //W
            //    Constraint.RelativeToParent((c) => { return c.Height * 0.083; }));                      //H 

            vistaGeneral.Children.Add(miControlDeBusqueda);

            contenedorPrincipal.Children.Add(vistaGeneral,
                Constraint.RelativeToParent((c) => { return c.Width * 0.0133333333333333; }),           //X
                Constraint.RelativeToParent((c) => { return 60; }),                                     //Y
                Constraint.RelativeToParent((c) => { return c.Width * 0.9413333333; }),                 //W
                Constraint.RelativeToParent((c) => { return c.Height * 0.8770614693; }));               //H 

            contenedorPrincipal.Children.Add(lista1,
                Constraint.RelativeToParent((c) => { return 10; }),                                     //X
                Constraint.RelativeToParent((c) => { return 110; }),                                    //Y
                Constraint.RelativeToParent((c) => { return c.Width * 0.9413333333; }),                 //W
                Constraint.RelativeToParent((c) => { return 480; }));                                   //H 

            contenedorPrincipal.Children.Add(Agregar,
                Constraint.RelativeToParent((c) => { return 270; }),                                    //X
                Constraint.RelativeToParent((c) => { return 480; }),                                    //Y
                Constraint.RelativeToParent((c) => { return 54; }),                                     //W
                Constraint.RelativeToParent((c) => { return 54; }));                                    //H 

            contenedorPrincipal.Children.Add(loading,
                Constraint.RelativeToParent((c) => { return 0; }),                                      //X
                Constraint.RelativeToParent((c) => { return 0; }),                                      //Y
                Constraint.RelativeToParent((c) => { return c.Width; }),                                //W
                Constraint.RelativeToParent((c) => { return c.Height; }));                              //H 

            Content = contenedorPrincipal;
        }

        void AgregarEventos()
        {
            miControlDeBusqueda.TextChanged += MiControlDeBusqueda_TextChanged;

            botonAgregar.Tapped += BotonAgregar_Tapped;

            lista1.ItemSelected += Lista1_ItemSelected;            
        }

        private void Lista1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = false;
        }

        private void BotonAgregar_Tapped(object sender, EventArgs e)
        {
            AnimacionSaltoBoton(Agregar);
        }

        void LlenadoDeEstudiantesQuemados()
        {
            MiListaEstudiantil2.Add("Carlos");
            MiListaEstudiantil2.Add("Enrique");
            MiListaEstudiantil2.Add("David");
        }

        private void MiControlDeBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == null) return;
            string nuevoValor = miControlDeBusqueda.Text;
            if (nuevoValor.Length >= 11)
                miControlDeBusqueda.Text = nuevoValor.Remove(nuevoValor.Length - 1);
        }

        async void AnimacionSaltoBoton(Image control)
        {
            uint tiempo = 200;
            await control.ScaleTo(0.85, tiempo);
            await control.ScaleTo(1, tiempo);
            if (string.IsNullOrEmpty(miControlDeBusqueda.Text))
            {
                await App.Current.MainPage.DisplayAlert("Notificación", "Debe escribir un nombre", "Aceptar");
                return;
            }
            loading.IsVisible = true;
            await Task.Delay(1000);
            loading.IsVisible = false;
            MiListaEstudiantil2.Add(miControlDeBusqueda.Text);
            miControlDeBusqueda.Text = string.Empty;
        }
    }
}