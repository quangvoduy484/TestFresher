using Microsoft.EntityFrameworkCore;
using MoviePorject.Interface;
using MoviePorject.Models;
using MoviePorject.Reponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePorject.BA
{
    public class MovieBusiness : IMovie
    {
        public MovieContext _context;
        public MovieBusiness(MovieContext context)
        {
            _context = context;
        }

        public BaseResponse addMovie(Movie movie)
        {
            if (string.IsNullOrWhiteSpace(movie.MovieName))
            {
                return new BaseResponse
                {
                    ErrorCode = 1,
                    Messege = "Dữ liệu không được để trống!!"
                };
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return new BaseResponse
            {
                ErrorCode = 0,
                Messege = "Add Success!!",
                Data = movie
            };

        }

        public BaseResponse getMovies()
        {
            //var Movies = _context.Movies.Include(x => x.MovieDetails).ToList();
            var Movies = _context.Movies.ToList();
            if (Movies == null)
            {
                return new BaseResponse { ErrorCode = 1, Messege = "List Empty" };
            }
            return new BaseResponse(Movies);

        }

        // ai post và post trong thời gian nào 
        public BaseResponse getReportMovies()
        {
            var Movies = _context.MovieDetails.Include(x => x.Movie).Include(x => x.Person).ToList();
            if (Movies == null)
            {
                return new BaseResponse { ErrorCode = 1, Messege = "Danh sách rỗng" };
            }

            var DetailMovies = Movies.Select(x => new
            {
                NamePerson = x.Person.PersonName,
                Post = new List<object>
                {
                   new { NameMovie = x.Movie.MovieName, DatePost  =String.Format("{0:dd/MM/yyyy}", x.CreateBy) }
                }
            }).ToList();

            return new BaseResponse
            {
                ErrorCode = 0,
                Messege = "Load Success",
                Data = DetailMovies
            };

        }

    }
}
