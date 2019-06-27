using MoviePorject.Models;
using MoviePorject.Reponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePorject.Interface
{
    public interface IMovie
    {
        BaseResponse addMovie(Movie movie);
        BaseResponse getMovies();
        BaseResponse getReportMovies();
    }
}
