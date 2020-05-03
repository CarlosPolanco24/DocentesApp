using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DocentesApp
{
    public class Login : ContentPage
    {
        //Logo
        Image logoUtap;

        //Bienvenidos
        Label labelBienvenidos,
              OlvidarContraseña;

        //Campos
        Entry Documento, Codigo, Contraseña;

        //Gestos
        TapGestureRecognizer TapOlvidarContrasena, botonRegresar;

        //Boton
        Button AccesoApp;

        //Cajas 
        BoxView Fondo, circulo;

        Cargando loading;

        StackLayout Contenido;

        RelativeLayout contenedorLogin;

        //PaginaPricipal paginaPrincipal;

        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }

        void CrearVistas()
        {
            loading = new Cargando();

         
            //paginaPrincipal = new PaginaPricipal
            //{
            //    TranslationX = 420
            //};

            Fondo = new BoxView
            {
                BackgroundColor = Colores.FondoLogin
            };

            logoUtap = new Image
            {
                Source = Imagenes.LogoUtap
            };

            labelBienvenidos = new Label
            {
                Text = "Bienvenidos",
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Colores.BLanco,
                FontSize = Palabras.Texto_Bienvenidos
            };

            Documento = new Entry
            {
                Placeholder = "No. Documento",
                PlaceholderColor = Colores.BLanco,
                FontSize = Palabras.CajasTextoLogin
                //Keyboard = Keyboard.Numeric
            };

            Codigo = new Entry
            {
                Placeholder = "Codigo",
                PlaceholderColor = Colores.BLanco,
                FontSize = Palabras.CajasTextoLogin
                //Keyboard = Keyboard.Numeric
            };

            Contraseña = new Entry
            {
                Placeholder = "Contraseña",
                PlaceholderColor = Colores.BLanco,
                IsPassword = true,
                FontSize = Palabras.CajasTextoLogin
            };

            AccesoApp = new Button
            {
                Text = "Acceder a la App",
                BackgroundColor = Colores.Boton,
                TextColor = Colores.Negro,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            OlvidarContraseña = new Label
            {
                Text = "¿Olvido su Contraseña?",
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Colores.BLanco,
                FontSize = Palabras.EnlacesLogin
            };

            circulo = new BoxView
            {
                BackgroundColor = Color.Green,
                CornerRadius = 40,
                Scale = 20
            };

            Contenido = new StackLayout();

            contenedorLogin = new RelativeLayout();

            // Eventos
            botonRegresar = new TapGestureRecognizer();

            TapOlvidarContrasena = new TapGestureRecognizer();
            OlvidarContraseña.GestureRecognizers.Add(TapOlvidarContrasena);

            Content = AccesoApp;
        }



        void AgregarVistas()
        {
            contenedorLogin.Children.Add(Fondo,
                Constraint.RelativeToParent((c) => { return 0; }),                              //X
                Constraint.RelativeToParent((c) => { return 0; }),                              //Y
                Constraint.RelativeToParent((c) => { return 375; }),                            //W
                Constraint.RelativeToParent((c) => { return 667; }));                           //H 

            contenedorLogin.Children.Add(logoUtap,
                Constraint.RelativeToParent((c) => { return 20; }),                             //X
                Constraint.RelativeToParent((c) => { return 90; }),                             //Y
                Constraint.RelativeToParent((c) => { return 329; }),                            //W
                Constraint.RelativeToParent((c) => { return 102; }));                           //H 

            contenedorLogin.Children.Add(labelBienvenidos,
                Constraint.RelativeToParent((c) => { return 37.5; }),                           //X
                Constraint.RelativeToParent((c) => { return 228; }),                            //Y
                Constraint.RelativeToParent((c) => { return 300; }),                            //W
                Constraint.RelativeToParent((c) => { return 50; }));                            //H 

            Contenido.Children.Add(Documento);
            Contenido.Children.Add(Codigo);
            Contenido.Children.Add(Contraseña);

            contenedorLogin.Children.Add(Contenido,
                Constraint.RelativeToParent((c) => { return 64; }),                             //X
                Constraint.RelativeToParent((c) => { return 310; }),                            //Y
                Constraint.RelativeToParent((c) => { return 250; }),                            //W
                Constraint.RelativeToParent((c) => { return 120; }));                           //H 

            contenedorLogin.Children.Add(AccesoApp,
                Constraint.RelativeToParent((c) => { return 50; }),                             //X
                Constraint.RelativeToParent((c) => { return 500; }),                            //Y
                Constraint.RelativeToParent((c) => { return 250; }),                            //W
                Constraint.RelativeToParent((c) => { return 42; }));                            //H 

            contenedorLogin.Children.Add(OlvidarContraseña,
                Constraint.RelativeToParent((c) => { return 100; }),                            //X
                Constraint.RelativeToParent((c) => { return 560; }),                            //Y
                Constraint.RelativeToParent((c) => { return 161; }),                            //W
                Constraint.RelativeToParent((c) => { return 15; }));                            //H 

            //contenedorLogin.Children.Add(circulo,
            //    Constraint.RelativeToParent((c) => { return c.Width * 0.45; }),                //X
            //    Constraint.RelativeToParent((c) => { return c.Height * 0.45; }));              //Y

            //contenedorLogin.Children.Add(paginaPrincipal,
            //    Constraint.RelativeToParent((c) => { return 0; }),                              //X
            //    Constraint.RelativeToParent((c) => { return 0; }),                              //Y
            //    Constraint.RelativeToParent((c) => { return c.Width; }),                        //W
            //    Constraint.RelativeToParent((c) => { return c.Height; }));                      //H 


            contenedorLogin.Children.Add(loading,
               Constraint.RelativeToParent((c) => { return 0; }),                               //X
               Constraint.RelativeToParent((c) => { return 0; }),                               //Y
               Constraint.RelativeToParent((c) => { return c.Width; }),                         //W
               Constraint.RelativeToParent((c) => { return c.Height; }));                       //H

            Content = contenedorLogin;
        }

        void AgregarEventos()
        {
            AccesoApp.Clicked += AccesoApp_Clicked;
            //botonRegresar.Tapped += BotonRegresar_Tapped;
            TapOlvidarContrasena.Tapped += TapOlvidarContrasena_Tapped;
        }

        private async void TapOlvidarContrasena_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlvidoPassword());
        }

        private async void AccesoApp_Clicked(object sender, EventArgs e)
        {
            //UInt16 Time = 180;

            //await AccesoApp.TranslateTo(0, 10, Time);
            //await AccesoApp.TranslateTo(10, 0, Time);            

            //Logica Login

            Validaciones val = new Validaciones();

            //Validaciones Documento
            bool validadocumento = val.ValidarNumeroDocumento(Documento);
            if (validadocumento)
            {
                await DisplayAlert("Error", "Por Favor Ingrese Un Numero de Documento.", "Aceptar");
            }
            else
            {
                bool validartipo = val.ValidarCodigoEstudianteNumerico(Documento);
                if (validartipo)
                {
                    await DisplayAlert("Error", "El Numero de documento no es valido, este debe ser numerico.", "Aceptar");
                }
                else
                {
                    bool validartamano = val.ValidarTamanoNumeroDocumento(Documento);
                    if (!validartamano)
                    {
                        await DisplayAlert("Error", "El Numero de documento no es valido, este debe ser de 10 caracteres.", "Aceptar");
                    }
                    else
                    {
                        await DisplayAlert("Notificacion", "Documento Verificado.", "Aceptar");
                    }
                }
            }

            //Validaciones Codigo Estudiante
            bool validacodigo = val.ValidarCodigoEstudiante(Codigo);
            if (validacodigo)
            {
                await DisplayAlert("Error", "Por Favor Ingrese un codigo de estudiante.", "Aceptar");
            }
            else
            {
                bool validartipo = val.ValidarCodigoEstudianteNumerico(Codigo);
                if (validartipo)
                {
                    await DisplayAlert("Error", "El codigo no es valido, este debe ser numerico.", "Aceptar");
                }
                else
                {
                    await DisplayAlert("Notificacion", "Codigo Verificado.", "Aceptar");
                }
            }

            //Validaciones Password
            bool validarpassword = val.ValidarCajasTextoContraseña(Contraseña);
            if (validarpassword)
            {
                await DisplayAlert("Error", "Por Favor Ingrese Una Contraseña", "Aceptar");
            }
            else
            {
                bool validarcampocontrasena = val.ValidarCampoContraseñas(Contraseña);
                if (!validarcampocontrasena)
                {
                    await DisplayAlert("Error", "Su contraseña debe tener minimo 8 digitos", "Aceptar");
                }
                else
                {
                    //Video
                    var respuesta = DependencyService.Get<IRestApi>().LoginApp(Documento.Text, Codigo.Text, Contraseña.Text);
                    if (respuesta.exitoso == 1)
                    {
                        //await paginaPrincipal.TranslateTo(0, 0, 500);                        

                        await DisplayAlert("Notificacion", "Bienvenido.", "Aceptar");

                        await Task.Delay(1000);

                        loading.IsVisible = true;
                        await Task.Delay(1000);
                        loading.IsVisible = false;

                        await Navigation.PushAsync(App._masterpage);

                    }
                    else
                    {
                        await DisplayAlert("Notificación", "Error al intentar conectarse con el servidor", "Aceptar");
                    }
                    //                    

                    //Rectangle dimensiones = paginaPrincipal.Bounds;
                    //await paginaPrincipal.TranslateTo(0, 0, 200);

                    //await Navigation.PushAsync(App._masterpage);
                }
            }
            //Fin Logica Login
            
        }

        //private async void BotonRegresar_Tapped(object sender, EventArgs e)
        //{
        //    //await paginaPrincipal.TranslateTo(450, 0, 200);

        //    botonVolver.IsVisible = false;
        //}

        //Animacion Boton
        async Task AnimacionInicial()
        {
            UInt16 Time = 130;

            await AccesoApp.ScaleTo(0.8, Time); //Valores entre 0 y 1, velocidad en milisegundos
            await AccesoApp.ScaleTo(1, Time);
        }

        //Animacion Circulos
        async Task AnimacionCirculo()
        {
            UInt16 Time = 1000;

            await circulo.ScaleTo(20, Time);
            await circulo.ScaleTo(0, Time);

            circulo.BackgroundColor = Color.Red;

            await circulo.ScaleTo(20, Time);

            await circulo.FadeTo(0, 700);

            circulo.IsVisible = false;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //await Task.Delay(1000);

            await AnimacionCirculo();

            await AnimacionInicial();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}