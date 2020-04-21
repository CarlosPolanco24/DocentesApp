using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace DocentesApp
{
    public class EstiloTemplate : ViewCell
    {
        public EstiloTemplate()
        {
            StackLayout CeldaPadre = new StackLayout
            {
                Padding = 10,    //Espacio qlrededor de todo (arriba,derecha,abajo,izquierda)-> Padding = new Thickness(10,10,10,10)
                BackgroundColor = Colores.BarraNavegacion,
                WidthRequest = 375,
                HeightRequest = 70
            };

            //Orden icono - Nombre
            StackLayout Contenedor = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            Label label = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,                     //Color del texto del menu.
                FontSize = Palabras.Items_Lista,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            //SetBinding Acopla el objeto y lo acomoda deacuerdo a la propiedad.
            //Esto es lo que muestra lo del VistaMenuMaster.
            label.SetBinding(Label.TextProperty, "Titulo");

            Contenedor.Children.Add(label);

            CeldaPadre.Children.Add(Contenedor);

            View = CeldaPadre;
        }
    }
}
