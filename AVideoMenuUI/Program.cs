using System;
using System.Collections.Generic;
using videoMenuBLL;
using videoMenuEntity;

namespace AVideoMenuUI


{
    public class Class1
    {
        static BLLFacade bllFacade = new BLLFacade();


        public static void Main(string[] args)
        {



            Videoes vid = new Videoes()
            {
                VideoName = "Fish talks: ",
                VideoLenght = " Videolenght 5:0 minutes:" + " Video id: ",
                //VideoId = Id++
            };
            bllFacade.GetVideoService().Create(vid);

            bllFacade.GetVideoService().Create(new Videoes()
            {
                VideoName = "Bob goes to the store: ",
                VideoLenght = " Videolenght 5:0 minutes:" + " Video id: ",
                //VideoId = id++
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
            while (selection != 5)
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

            return bllFacade.GetVideoService().Get(id);
        }

        private static void DeleteVideos()
        {
            var videoFound = FindVideoById();
            if (videoFound != null)
            {
                bllFacade.GetVideoService().Delete(videoFound.VideoId);
            }
            var response = videoFound == null ? "Video not found" : "video was deleted";
            Console.WriteLine(response);
        }


        public static void EditVideo()
            {
                var videoes = FindVideoById();
                if (videoes != null)
                {
                    Console.WriteLine("name");
                    videoes.VideoName = Console.ReadLine();
                }
                var response = videoes == null ? "Video not found" : "video was edited";
            Console.WriteLine(response);

            }

            private static void AddVideos()
            {
                Console.WriteLine("Name:  ");
                var name = Console.ReadLine();

                bllFacade.GetVideoService().Create(new Videoes()
                {
                    VideoName = name
                  
                });
            }


            public static void listvideo()
            {
                foreach (var vidoes in bllFacade.GetVideoService().GetAll())
                {
                    Console.WriteLine($"Name : {vidoes.VideoName}" + $"{vidoes.VideoLenght}" + $"{vidoes.VideoId}");
                }
                
            }

        }
    }




