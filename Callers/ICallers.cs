using OMDB_API.Models;
using System.Collections.Generic;

namespace OMDB_API.Callers
{
    public interface ICallers
    {
        MovieSearch GetMovies(string Title, int Page);
        Movie GetMovie(string Title);


    }
}
