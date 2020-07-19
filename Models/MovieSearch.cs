using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace OMDB_API.Models
{
    class MovieSearch
    {

        public List<Movie> Search { get; set; }
        public string Response { get; set; }
        public string totalResults { get; set; }
        public string Error { get; set; }

    }
}
