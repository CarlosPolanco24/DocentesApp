using System;
using System.Collections.Generic;
using System.Text;

namespace DocentesApp
{
    public interface IRecuperar
    {
        ResponseRescuperarContrasena OlvidarContrasenaApp(string Email);
    }
}
