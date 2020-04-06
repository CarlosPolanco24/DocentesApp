using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DocentesApp
{
    public class Imagenes 
    {
        public static ImageSource LogoUtap { get; } = ImageSource.FromFile("LogoUtap.png");
        public static ImageSource BotonMas { get; } = ImageSource.FromFile("botonMas.png");
        public static ImageSource BotonVolver { get; } = ImageSource.FromFile("botonVolver.png");
    }
}