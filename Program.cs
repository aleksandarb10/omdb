using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using WindowsFormsApp1.Callers;
using WindowsFormsApp1.Models;
using OMDB_API.Callers;
//using RestSharpDemo.Caller.Callers;
//using RestSharpDemo.Caller.Models;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OMDb());


 



        }
    }
}
