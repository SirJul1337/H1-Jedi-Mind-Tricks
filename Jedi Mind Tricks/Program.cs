using System;
using System.Collections.Generic;
namespace Jedi_Mind_Tricks
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> characters = new Dictionary<string, int>()
            {
            { "Luke", 24 },
            { "Han", 17 },
            { "Chewbacca", 500 }
            };

            characters.Add("Niklas", 18);
            
            if (characters.Remove("Han"))
            {
                Console.WriteLine("Han has been removed");
            }
            else
            {
                Console.WriteLine("Couldnt find Han");
            }


            foreach(var character in characters)
            {
                Console.WriteLine(character);
            }
        }
    }
}

