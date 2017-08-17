using System;
using System.Linq.Expressions;

namespace videoMenu
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("select what you want to do");
            Console.WriteLine("_______________________________");
            string[] menuItems =
            {

                "List all the videoes",
                "Add new video",
                "Video options",
                "Exit"

            };

           
    
            var selection = ShowMenu(menuItems);
            while (selection !=4)
            {

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("List of videoes");
                       
                        string[] vidoes =
                        {

                            "Cats playing with dogs",
                            "fish drowning",
                            "Cow barking",
                            "Exit"
                           
                        };
                        for (int i = 0; i < menuItems.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ": " + vidoes[i]);


                        }
                        int exit;
                        
                        exit = int.Parse(Console.ReadLine());
                        if (exit == 4)
                        {
                            System.Environment.Exit(4);
                        }
                        break;
                    case 2:
                        Console.WriteLine("add a new video");
                        break;
                    case 3:
                        Console.WriteLine("Video options");
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        System.Environment.Exit(4);
                        break;
                }
                //selection = ShowMenu(menuItems);
            }
            Console.WriteLine("bye world");

            
        }

        private static int ShowMenu(string[] menuItems)
        {

                
            //Console.WriteLine("select what you want to do");
            //Console.WriteLine("_______________________________");

            for (int i = 0; i < menuItems.Length; i++)
            {

                Console.WriteLine((i + 1) + ": " + menuItems[i]);
                
                

            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 0 || selection > 4)
            {
             
                Console.WriteLine("you need to select a number between 1-4");
              
            }

            //Console.WriteLine("You have selected " + selection);
            
            return selection;

        }
       
    

}
}
    

