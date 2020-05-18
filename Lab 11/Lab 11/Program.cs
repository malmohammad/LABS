using System;
using System.Collections.Generic;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var appName = "Movie List Application";
            var movieList = new List<Movies>();

            movieList.Add(new Movies("Toy Story", Category.animated));
            movieList.Add(new Movies("The Grudge", Category.horror));
            movieList.Add(new Movies("Creed", Category.drama));
            movieList.Add(new Movies("The Avengers", Category.scifi));
            movieList.Add(new Movies("Finding Nemo", Category.animated));
            movieList.Add(new Movies("Chapter Two", Category.horror));
            movieList.Add(new Movies("The Godfather", Category.drama));
            movieList.Add(new Movies("Transformers", Category.scifi));
            movieList.Add(new Movies("The Lion King", Category.animated));
            movieList.Add(new Movies("Underwater", Category.horror));
           
                
            Console.WriteLine($"Thank you for joining {appName}, there are 10 movies in this list");

            do
            {
                Category movieType;

                bool valid;
                do
                {
                    Console.WriteLine($"What category are you interested in? \nPlease pick from: \n(1) {Category.animated}, \n(2) {Category.horror}, \n(3) {Category.drama}, \n(4) {Category.scifi}");
                    valid = Category.TryParse(Console.ReadLine(), out movieType);
                }while (!valid);
                Console.WriteLine($"\nHere are the {movieType} of movies we have");
                foreach (var movie in movieList)
                {
                    if (movie.GetCategory() == movieType)
                        Console.WriteLine(movie.GetTitle());
                }
                Console.WriteLine("Would you like to continue? y/n");
            } while (Console.ReadLine() == "y");
            
            





        }
    }
}
