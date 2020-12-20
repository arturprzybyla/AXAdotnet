using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;

namespace AXAdotnet.API
{
    public static class GetFilmsController
    {
        [HttpGet]
        public static ApiResponse GetFilms()
        {
            var client = new RestClient($"https://swapi.dev/api/films/");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var z = response.Content;
            var x = JsonSerializer.Deserialize<ApiResponse>(z);
            return x;
        }
    }
}
