using System;
using DocentesApp;
using DocentesApp.Droid;
using Newtonsoft.Json;
using RestSharp;
using Xamarin.Forms;

[assembly: Dependency(typeof(Api))]

namespace DocentesApp.Droid
{
    public class Api : IRestApi
    {
        public ResponseApi LoginApp()
        {
			try
			{
				RestClient _Client = new RestClient("http://gowtic.com/api_test/ut0-0.php");
				RestRequest _request = new RestRequest("", Method.POST)
				{ RequestFormat = DataFormat.Json };

				_request.AddParameter("usuario", "Utap");
				_request.AddParameter("password", "123456");
				//_request.AddBody();

				var respuesta = _Client.Execute(_request);
				Console.WriteLine("The Server return: " + respuesta.Content);

				var responseApi = JsonConvert.DeserializeObject<ResponseApi>(respuesta.Content);


				return responseApi;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw ex;
			}
        }
    }
}