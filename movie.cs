using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Movie
{
    public Movie(string title, string category)
    {
        Title = title;
        Category = category;
    }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }

    public string Category { get; set; }
    // Add more properties as needed (e.g., director, cast, duration, etc.)  
    

}