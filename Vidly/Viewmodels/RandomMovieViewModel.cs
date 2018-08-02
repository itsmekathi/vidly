using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.Viewmodels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}