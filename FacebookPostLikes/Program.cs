using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPostLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of likes on your Facebook post");
            Console.WriteLine();

            var names = new List<string>();
            string userInput;
            
            while (true)
            {
                Console.Write("Enter Name or leave blank to submit:");
                userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput))
                { 
                    names.Add(userInput);
                }
                else
                {
                    break;
                }
            }

            if (names.Count == 0)
            {
                Console.WriteLine("No one liked your post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("[{0}] Likes your post", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("[{0}] and [{1}] Like your post", names[0], names[1]);
            }
            else if (names.Count >= 3)
            {
                Console.WriteLine("[{0}] and [{1}] and [{2}]others Like your post", names[0], names[1], names.Count - 2);
            }

            Console.ReadKey();
        }
    }
}
