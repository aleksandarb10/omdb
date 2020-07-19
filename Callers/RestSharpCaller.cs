
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMDB_API.Callers;
using OMDB_API.Models;
using RestSharp;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Callers
{
    class RestSharpCaller : ICallers
    {
        private RestClient client;
    

        public RestSharpCaller(string baseUrl)  
        {
            client = new RestClient(baseUrl);
        }

        public MovieSearch GetMovies(string Title, int Page)
        {
            var request = new RestRequest("?s="+ Title + "&page=" + Page.ToString(), Method.GET);
            var response = client.Execute<MovieSearch>(request);
            return response.Data;

        }
        public Movie GetMovie(string Title)
        {
            var request = new RestRequest("?i=" + Title, Method.GET);
            var response = client.Execute<Movie>(request);
            return response.Data;

        }





    }
}
