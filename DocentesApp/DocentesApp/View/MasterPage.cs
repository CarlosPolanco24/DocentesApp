using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace DocentesApp
{
    public class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Page _PaginaPrincipal = new VistaMenuMaster();
            Master = _PaginaPrincipal;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PaginaPricipal)))
            {
                BarBackgroundColor = Colores.BarraNavegacion,
                BarTextColor = Color.White
            };
        }
    }
}
