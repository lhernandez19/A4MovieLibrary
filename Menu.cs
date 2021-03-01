using System;
using System.IO;

namespace A4MovieLibrary
{
    public class Menu
    {
        public void MediaType(){
            Console.WriteLine("Select media type\n");
            Console.WriteLine("1. Movie");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Video");
            Console.WriteLine("4. Exit\n");
        }
        public void ActionMenu(){
            Console.WriteLine("Make a selection\n");
            Console.WriteLine("1. See content");
            Console.WriteLine("2. Add new content");
            Console.WriteLine("3. Exit\n");
        }
        public void MenuSelection() {
            int menuSelection = 0;
            string option;

            do{
                MediaType();
                menuSelection = Int32.Parse(Console.ReadLine());
                switch(menuSelection){
                    case 1: 
                        do{
                            ActionMenu();
                            menuSelection = Int32.Parse(Console.ReadLine());
                            if(menuSelection == 1){
                            Movie readMovies = new Movie();
                            do{
                                readMovies.Read();
                                System.Console.WriteLine("Do you want to display more movies? (Y/N)");
                                option = Console.ReadLine().ToUpper();
                            }while(option == "Y");
                            
                            }else if(menuSelection == 2){
                            Movie addMovie = new Movie();
                            do{
                                addMovie.Write();
                                System.Console.WriteLine("Do you want to add another movie? (Y/N)");
                                option = Console.ReadLine().ToUpper();
                            }while(option == "Y");
                            }else{
                            Console.WriteLine("Closing window....");
                            }
                        }while( menuSelection != 3);
                    break;
                    case 2: 
                        do{
                            ActionMenu();
                            menuSelection = Int32.Parse(Console.ReadLine());
                            if(menuSelection == 1){
                            Show readShows = new Show();
                            do{
                                readShows.Read();
                                System.Console.WriteLine("Do you want to display more shows? (Y/N)");
                                option = Console.ReadLine().ToUpper();
                            }while(option == "Y");
                            
                            }else if(menuSelection == 2){
                            Show addShows = new Show();
                            do{
                                addShows.Write();
                                System.Console.WriteLine("Do you want to add another show? (Y/N)");
                                option = Console.ReadLine().ToUpper();
                            }while(option == "Y");
                            }else{
                            Console.WriteLine("Closing window....");
                            }
                        }while(menuSelection != 3);
                    break;
                    case 3: 
                        do{
                            ActionMenu();
                            menuSelection = Int32.Parse(Console.ReadLine());
                            if(menuSelection == 1){
                            Video readVideos = new Video();
                            do{
                                readVideos.Read();
                                System.Console.WriteLine("Do you want to display more videos? (Y/N)");
                                option = Console.ReadLine().ToUpper();
                            }while(option == "Y");
                            
                            }else if(menuSelection == 2){
                            Video addVideo = new Video();
                            do{
                                addVideo.Write();
                                System.Console.WriteLine("Do you want to add another video? (Y/N)");
                                option = Console.ReadLine().ToUpper();
                            }while(option == "Y");
                            }else{
                            Console.WriteLine("Closing window....");
                            }
                        }while( menuSelection != 3);
                    break;
                }
            }while(menuSelection != 4); 

        }
    }
}   
