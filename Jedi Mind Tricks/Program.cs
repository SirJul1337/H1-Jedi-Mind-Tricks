using System;
using System.Collections.Generic;
namespace Jedi_Mind_Tricks
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> person = new Dictionary<string, int>();
            person["Jørgen"] = 20;
            person.Add("Niklas", 18);
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
            { "Luke", true },
            { "Han", false },
            { "Chewbacca", true }
            };
            
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

