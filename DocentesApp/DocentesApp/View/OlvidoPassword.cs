using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DocentesApp
{
    public class OlvidoPassword : ContentPage
    {
        RelativeLayout ContenedorPassword;

        Entry entryEmail;

        Label labelOlvidarContraseña;

        Button buttonRecuperar;

        BoxView barraNavegacion;

        Image regresar;

        TapGestureRecognizer TapRegresar;

        Cargando loading;

        public OlvidoPassword()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }

        void CrearVistas()
        {
            loading = new Cargando();

            barraNavegacion = new BoxView
            {
                BackgroundColor = Colores.BarraNavegacion
            };

            regresar = new Image
            {
                Source = Imagenes.BotonVolver
            };

            labelOlvidarContraseña = new Label
            {
                Text = "Recuperar Contraseña",
                TextColor = Color.Black,
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Palabras.TextosInformativos
            };

            entryEmail = new Entry
            {
                Placeholder = "Correo Institucional",
                PlaceholderColor = Color.Black,
                FontSize = Palabras.CajasTextoLogin,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            buttonRecuperar = new Button
            {
                Text = "Recuperar",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Colores.BarraNavegacion,
                TextColor = Color.White
            };

            TapRegresar = new TapGestureRecognizer();
            regresar.GestureRecognizers.Add(TapRegresar);

            ContenedorPassword = new RelativeLayout
            {
                BackgroundColor = Color.Transparent
            };
        }

        void AgregarVistas()
        {
            ContenedorPassword.Children.Add(barraNavegacion,
                Constraint.RelativeToParent((c) => { return 0; }),                                      //X
                Constraint.RelativeToParent((c) => { return 0; }),                                      //Y
                Constraint.RelativeToParent((c) => { return c.Width * 1; }),                            //W
                Constraint.RelativeToParent((c) => { return c.Height * 0.0839; }));                     //H

            ContenedorPassword.Children.Add(regresar,
                Constraint.RelativeToParent((c) => { return 0; }),                                      //X
                Constraint.RelativeToParent((c) => { return 0; }),                                      //Y
                Constraint.RelativeToParent((c) => { return c.Width * 0.1493; }),                       //W
                Constraint.RelativeToParent((c) => { return c.Height * 0.0839; }));                     //H

            ContenedorPassword.Children.Add(labelOlvidarContraseña,
                Constraint.RelativeToParent((c) => { return 50; }),                                     //X
                Constraint.RelativeToParent((c) => { return 275; }));                                   //Y

            ContenedorPassword.Children.Add(entryEmail,
                Constraint.RelativeToParent((c) => { return 50; }),                                     //X
                Constraint.RelativeToParent((c) => { return 304; }),                                    //Y
                Constraint.RelativeToParent((c) => { return 272; }),                                    //W
                Constraint.RelativeToParent((c) => { return 40; }));

            ContenedorPassword.Children.Add(buttonRecuperar,
                Constraint.RelativeToParent((c) => { return 112; }),                                    //X
                Constraint.RelativeToParent((c) => { return 409; }),                                    //Y
                Constraint.RelativeToParent((c) => { return 148; }),                                    //W
                Constraint.RelativeToParent((c) => { return 38; }));

            ContenedorPassword.Children.Add(loading,
                Constraint.RelativeToParent((c) => { return 0; }),                                      //X
                Constraint.RelativeToParent((c) => { return 0; }),                                      //Y
                Constraint.RelativeToParent((c) => { return c.Width; }),                                //W
                Constraint.RelativeToParent((c) => { return c.Height; }));

            Content = ContenedorPassword;
        }

        void AgregarEventos()
        {
            TapRegresar.Tapped += TapRegresar_Tapped;
            buttonRecuperar.Clicked += ButtonRecuperar_Clicked;
        }        

        private async void TapRegresar_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void ButtonRecuperar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryEmail.Text))
            {
                await DisplayAlert("Notificacion", "El Campo Correo Electronico esta vacio.", "Aceptar");
                return;
            }

            if (!entryEmail.Text.Contains("@"))
            {
                await DisplayAlert("Notificacion", "La direccion de correo No es valida, Falta un '@'.", "Aceptar");

                return;
            }

            if (!entryEmail.Text.Contains(".co"))
            {
                await DisplayAlert("Notificacion", "La direccion de correo No es valida, Falta un '.co'.", "Aceptar");

                return;
            }

            else
            {
                await DisplayAlert("Notificacion", "Se ha enviado un mensaje de verificacion a su correo.", "Aceptar");

                loading.IsVisible = true;
                await Task.Delay(1000);
                loading.IsVisible = false;

                return;
            }            
        }
    }
}