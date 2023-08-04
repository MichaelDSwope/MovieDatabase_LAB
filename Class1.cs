using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLAB
{



    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
