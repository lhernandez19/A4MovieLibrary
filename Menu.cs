using System;
using System.IO;

namespace A4MovieLibrary
{
    public class Menu
    {
        public void MenuList(){
            Console.WriteLine("Make a selection\n");
            Console.WriteLine("1. See movies");
            Console.WriteLine("2. Add movie");
            Console.WriteLine("3. Exit\n");
        }

        public void MenuSelection() {
            int menuSelection = 0;
            string option;

            do{
                MenuList();
                menuSelection = Int32.Parse(Console.ReadLine());
                    if(menuSelection == 1){
                        Movie readMovies = new Movie();
                        do{
                            readMovies.ReadMovies();
                            System.Console.WriteLine("Do you want to display more movies? (Y/N)");
                            option = Console.ReadLine().ToUpper();
                        }while(option == "Y");
                        
                    }else if(menuSelection == 2){
                        Movie addMovie = new Movie();
                        do{
                            addMovie.AddMovie();
                            System.Console.WriteLine("Do you want to add another movie? (Y/N)");
                            option = Console.ReadLine().ToUpper();
                        }while(option == "Y");
                    }else{
                    Console.WriteLine("Closing program....");
                    }
            }while( menuSelection != 3);   
        }
    }
}   
