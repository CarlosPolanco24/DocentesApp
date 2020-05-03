using System;

namespace DocentesApp
{
    public interface IRestApi
    {
        ResponseApi LoginApp(string DocumentID, string Code, string Password);
    }
}