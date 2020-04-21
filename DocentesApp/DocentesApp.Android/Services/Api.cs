using System;
using RestSharp;

namespace DocentesApp.Droid
{
    public class Api : IRestApi
    {
        public bool CreateClients()
        {
			try
			{
				RestClient _Client = new RestClient("");
				RestRequest _request = new RestRequest("", Method.POST)
				{ RequestFormat = DataFormat.Json };

				//_request.AddBody();

				var respuesta = _Client.Execute(_request);
				Console.WriteLine("The Server return: " + respuesta.Content);

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
        }
    }
}