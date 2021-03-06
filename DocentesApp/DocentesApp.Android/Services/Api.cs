﻿using System;
using DocentesApp;
using DocentesApp.Droid;
using Newtonsoft.Json;
using RestSharp;
using Xamarin.Forms;

[assembly: Dependency(typeof(Api))]
[assembly: Dependency(typeof(ApiPassword))]

namespace DocentesApp.Droid
{
    public class Api : IRestApi
    {
        public ResponseApi LoginApp(string DocumentID, string Code, string Password)
        {
			try
			{
				RestClient _Client = new RestClient("http://todoapicep.azurewebsites.net/api/login/authenticate");
				RestRequest _request = new RestRequest("", Method.POST)
				{ RequestFormat = DataFormat.Json };

				_request.AddParameter("DocumentID", DocumentID);
				_request.AddParameter("Code", Code);
				_request.AddParameter("Password", Password);
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

	public class ApiPassword : IRecuperar
	{
		public ResponseRescuperarContrasena OlvidarContrasenaApp(string Email)
		{
			try
			{
				RestClient _Client = new RestClient("http://todoapicep.azurewebsites.net/api/recuperarcontrasena/authenticate");
				RestRequest _request = new RestRequest("", Method.POST)
				{ RequestFormat = DataFormat.Json };

				_request.AddParameter("Email", Email);
				//_request.AddBody();

				var respuesta = _Client.Execute(_request);
				Console.WriteLine("The Server return: " + respuesta.Content);

				var responseRecuperacionApi = JsonConvert.DeserializeObject<ResponseRescuperarContrasena>(respuesta.Content);


				return responseRecuperacionApi;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw ex;
			}
		}
	}
}