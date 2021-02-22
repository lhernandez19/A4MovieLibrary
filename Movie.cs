using System;
using NLog;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace A4MovieLibrary
{
    public class Movie{
        public int MovieID { get; set;}
        public string Title { get; set;}
        public string Genres { get; set;}
        private static string File = "movies.csv";
        
        // Read Movies
        public void ReadMovies()
        {
            Console.WriteLine("How many movie do you want to be displayed? ");
            int numberOfMovies = Int32.Parse(Console.ReadLine());
            
            StreamReader reader = new StreamReader("movies.csv");

            for(int i = 0; i < numberOfMovies + 1 ; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);    
            }
        }
        
        // Add Movie
        public void AddMovie()
        {
            MovieID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File, true);

            Console.WriteLine("Enter a new Title: ");
            string movieTitle = Console.ReadLine();

            var genres = new List<string>();
            string genre;
            string option;

            do
            {
                Console.WriteLine("Add genres: ");
                genre = Console.ReadLine();
                genres.Add(genre);
                Console.WriteLine("Do you want to add a genre: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newGenres =  string.Join("|", genres); 
            sw.WriteLine("{0},{1},{2}", MovieID, movieTitle, newGenres);
            sw.Close();
        }

        // Auto Increment ID
        private int getLastID()
        {
            int lastID = 0;
            try
            {
                string lastLine = System.IO.File.ReadLines(File).Last();
                string[] lastLineSplit = lastLine.Split(',');
                lastID = Convert.ToInt32(lastLineSplit[0]);
                return lastID;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }
            return lastID;
        }

    }
}
