using System;

namespace AdventureGame
{
    class Program
    {
        static void Main()
        {
            string CharacterName = "";

            Console.WriteLine("The Adventure Game!");
            Console.WriteLine("Welcome you brave soul...This Game will test all your skills");
            Console.ReadKey();
            Console.WriteLine("nunchuck skills...bowstaff skills...");
            Console.ReadKey();
            Console.WriteLine("Chances are..you won't make it out of this adventure alive");
            Console.ReadKey();
            Console.WriteLine("Type your name so we can put it on your headstone when you don't survive this adventure");          
            CharacterName = Console.ReadLine();
            Console.WriteLine("Welcome," + CharacterName + "...Prepare for awesomeness");
            Console.ReadKey();

            
                      

        }
    }
}
