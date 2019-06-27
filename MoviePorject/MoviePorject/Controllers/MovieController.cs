using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePorject.Interface;
using MoviePorject.Models;
using MoviePorject.Reponses;

namespace MoviePorject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovie _Movie;
        public MovieController(IMovie Movie)
        {
            _Movie = Movie;        
                
        }

        [HttpGet]
        public ActionResult<BaseResponse> getMovies()
        {
           return _Movie.getMovies();
        }

        [HttpPost]
        public ActionResult<BaseResponse> addMovie(Movie movie)
        {
            return _Movie.addMovie(movie);
        }

        [HttpGet("getReportMovies")]
        public ActionResult<BaseResponse> getReportMovies()
        {
            return _Movie.getReportMovies();
        }


    }
}