using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace DocentesApp
{
    public class Cargando : RelativeLayout
    {
        ActivityIndicator loading;
        public Cargando()
        {
            IsVisible = false;
            BackgroundColor = Colores.Principal.MultiplyAlpha(0.6);
            loading = new ActivityIndicator
            {
                Color = Color.White,
                IsRunning = true,
                IsVisible = true
            };

            Children.Add(loading,
                Constraint.RelativeToParent((c) => { return c.Width * 0.448; }),                    //X
                Constraint.RelativeToParent((c) => { return c.Height * 0.484; }),                   //Y
                Constraint.RelativeToParent((c) => { return c.Width * 0.106; }),                    //W
                Constraint.RelativeToParent((c) => { return c.Height * 0.059; }));                  //H 
        }
    }
}
