using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DocentesApp.Droid
{
    [Activity(Label = "DocentesApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            //Clase 17/09/2019
            var metricas = Resources.DisplayMetrics;

            Core.ScreenWidth = ConvertPixelsToDpi(metricas.WidthPixels);        //Tamaño pantalla Ancho(W).
            Core.ScreenHeigth = ConvertPixelsToDpi(metricas.HeightPixels);      //Tamaño pantalla Alto(H).

            //Quemamos los valores de alto y ancho
            Console.WriteLine("Ancho de mi pantalla:" + Core.ScreenWidth);
            Console.WriteLine("Alto de mi pantalla:" + Core.ScreenHeigth);
        }
        public int ConvertPixelsToDpi(float pixelsvalue)
        {
            var dp = (int)(pixelsvalue / Resources.DisplayMetrics.Density);
            return dp;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}