using System.Collections.Generic;
using System;

//MOVIE DATABASE
//Objectives: Lists of Objects and basic Database concepts

//Task: List movies by category.

//What will the application do?
//The application stores a list of 10 movies and displays them by category.
//The user can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi.
//After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.

//Build Specifications:

//Class has member variables of the correct type —2  points total
//Class has constructor—1 point
//In your program.cs file, create a List<Movie> and store at least 10 movies there. You can use literals to construct the movies. Make sure to have a mixture of categories.
//Program constructs list properly—1 point
//Program puts at least 10 properly instantiated Movies into the List—1 point
//When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
//Program takes user input correctly—1 point
//Program gives explicit feedback if user enters invalid category—1 point
//Program iterates through List validly—1 point
//Program only outputs if movie matches category—1 point
//Program loops if user wants to continue.
//Program loops back to ask category again based on user input—1 point

//Hints:
//Don’t overthink this! Think about how you would do this in real life if you work at a video store, and you have a stack of movies and somebody wants to see which movies in that stack belong to a particular category. When one customer asks for a list of movies, how many times do you loop through the stack of movies?

//Extra Challenges:
//Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name.
//Display the movies for the selected category in alphabetical order.
//Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.


using System;
using System.Collections.Generic;

namespace MovieDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the movie database with sample movies
            List<Movie> movieDatabase = new List<Movie>
            {
                new Movie("Akira", "animated"),
                new Movie("Eternal Sunshine", "drama"),
                new Movie("Sweeny Todd", "horror"),
                new Movie("Star Wars", "scifi"),
                new Movie("Minions", "animated"),
                new Movie("The God Father", "drama"),
                new Movie("UnderWorld", "horror"),
                new Movie("Altered Carbon", "scifi"),
                new Movie("Full Metal Alchemist", "animated"),
                new Movie("Devil's Advocate", "drama")
            };

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("Enter a category (animated, drama, horror, scifi) to display movies:  \n\t");
                string categoryInput = Console.ReadLine().ToLower();

                List<Movie> moviesInCategory = GetMoviesByCategory(movieDatabase, categoryInput);
                if (moviesInCategory.Count == 0)
                {
                    Console.WriteLine("No movies found in the selected category.");
                }
                else
                {
                    Console.WriteLine($"Movies in the {categoryInput} category:");
                    foreach (var movie in moviesInCategory)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueInput = Console.ReadLine().ToLower();
                continueProgram = (continueInput == "yes");
            }
        }

        static List<Movie> GetMoviesByCategory(List<Movie> movieDatabase, string category)
        {
            List<Movie> moviesInCategory = new List<Movie>();

            foreach (var movie in movieDatabase)
            {
                if (movie.Category.ToLower() == category)
                {
                    moviesInCategory.Add(movie);
                }
            }

            return moviesInCategory;
        }
    }

   
}