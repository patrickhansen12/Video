using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace videoMenu
{
    class Program
    {
        private static int id = 1;
        static List<Videoes> videoes = new List<Videoes>();
        public static void Main(string[] args)
        {
          
          
             Videoes vid = new Videoes()
            {
                VideoName = "Fish talks:",
                VideoLenght = " Videolenght 5:0 minutes:" + " Video id: ",
                VideoId = id++
            };
            videoes.Add(vid);
            videoes.Add(new Videoes()
            {
                VideoName = "Bob goes to the store:",
                VideoLenght = " Videolenght 5:0 minutes:" + " Video id: ",
                VideoId = id++
            });
            

            string[] menuItems =
            {

                "List all the videoes",
                "Add new video",
                "Delete a video",
                "Edit a video",
                "Exit"

            };

           
    
            var selection = ShowMenu(menuItems);
            while (selection !=5)
            {

                switch (selection)
                {

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("List of videoes");
                       listvideo();
                        Console.WriteLine("");
                     
                       

                        break;
                    case 2:
                        Console.WriteLine("add a new video");
                        AddVideos();
                     
                        break;
                    case 3:
                        Console.WriteLine("Delete Video");
                        DeleteVideos();
                        break;
                        case 4:
                            
                        EditVideo();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                       
                        break;
                }
                selection = ShowMenu(menuItems);
                
                
            }
          
            Console.WriteLine("bye world");

            
        }

        private static int ShowMenu(string[] menuItems)
        {

                
            Console.WriteLine("select what you want to do");
            Console.WriteLine("_______________________________");

            for (int i = 0; i < menuItems.Length; i++)
            {

                Console.WriteLine((i + 1) + ": " + menuItems[i]);
                
                

            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 0 || selection > 5)
            {
             
                Console.WriteLine("you need to select a number between 1-5");
              
            }

            //Console.WriteLine("You have selected " + selection);
            
            return selection;

        }
        private static Videoes FindVideoById()
        {
            Console.WriteLine("Insert Video Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }

            foreach (var Videoes in videoes)
            {
                if (Videoes.VideoId == id)
                {
                    return Videoes;
                }
            }
            return null;
        }
        private static void DeleteVideos()
        {
            var videoFound = FindVideoById();
            if (videoFound != null)
            {
                videoes.Remove(videoFound);
            }
        }

        public static void EditVideo()
        {
            var videoes = FindVideoById();
            Console.WriteLine("name");
            videoes.VideoName = Console.ReadLine();
        }
        private static void AddVideos()
        {
            Console.WriteLine("Name:  ");
            var name = Console.ReadLine();

            videoes.Add(new Videoes()
            {
                VideoName = name,
                VideoId = id++
            });
        }


        public static void listvideo()
        {
            foreach (var vidoes in videoes)
            {
                Console.WriteLine($"Name : {vidoes.VideoName}" + $"{vidoes.VideoLenght}" + $"{vidoes.VideoId}");
            }
        
        }

}
}
    

