using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakeTwoVideo.Models;

namespace TakeTwoVideo.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
    }
}