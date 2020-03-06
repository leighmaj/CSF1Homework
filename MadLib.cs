using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            string[] madLibArray = new string[19];

            Console.WriteLine("Please follow the prompts and enter in a corresponding word to complete the MadLib. " +
                "Verbs should be in present tense. Adverbs are words that modify verbs and often in in -ly.");

            Console.Write("\nPlease enter an adjective: ");
            madLibArray[0] = Console.ReadLine();

            Console.Write("\nPlease enter an adjective: ");
            madLibArray[1] = Console.ReadLine();

            Console.Write("\nPlease enter a noun: ");
            madLibArray[2] = Console.ReadLine();

            Console.Write("\nPlease enter a noun: ");
            madLibArray[3] = Console.ReadLine();

            Console.Write("\nPlease enter a plural noun: ");
            madLibArray[4] = Console.ReadLine();

            Console.Write("\nPlease enter a game: ");
            madLibArray[5] = Console.ReadLine();

            Console.Write("\nPlease enter a plural noun: ");
            madLibArray[6] = Console.ReadLine();

            Console.Write("\nPlease enter a verb ending in -ing: ");
            madLibArray[7] = Console.ReadLine();

            Console.Write("\nPlease enter a verb ending in -ing: ");
            madLibArray[8] = Console.ReadLine();

            Console.Write("\nPlease enter a plural noun: ");
            madLibArray[9] = Console.ReadLine();

            Console.Write("\nPlease enter a verb ending in -ing: ");
            madLibArray[10] = Console.ReadLine();

            Console.Write("\nPlease enter a noun: ");
            madLibArray[11] = Console.ReadLine();

            Console.Write("\nPlease enter a type of plant: ");
            madLibArray[12] = Console.ReadLine();

            Console.Write("\nPlease enter a part of the body: ");
            madLibArray[13] = Console.ReadLine();

            Console.Write("\nPlease enter a place: ");
            madLibArray[14] = Console.ReadLine();

            Console.Write("\nPlease enter a verb ending in -ing: ");
            madLibArray[15] = Console.ReadLine();

            Console.Write("\nPlease enter an adjective: ");
            madLibArray[16] = Console.ReadLine();

            Console.Write("\nPlease enter a number: ");
            madLibArray[17] = Console.ReadLine();

            Console.Write("\nPlease enter a plural noun: ");
            madLibArray[18] = Console.ReadLine();


            Console.WriteLine($"A vacation is when you take a trip to some {madLibArray[0]} place with your {madLibArray[1]} family. " +
                $"Usually you go to some place that is near a/an {madLibArray[2]} or up on a/an {madLibArray[3]}.A good vacation place " +
                $"is one where you can ride {madLibArray[4]} orplay {madLibArray[5]} or go hunting for {madLibArray[6]}. I like to spend " +
                $"my time {madLibArray[7]} or {madLibArray[8]}.When  parents  go  on  a  vacation,  they  spend  their  time  " +
                $"eating  three {madLibArray[9]} a day, and fathers play golf, and mothers sit around {madLibArray[10]}. Last summer, " +
                $"my little brother fell  in  a/an {madLibArray[11]} and  got  poison {madLibArray[12]} all over  his{madLibArray[13]}.  " +
                $"My  family  is  going  to  go  to  (the) {madLibArray[14]}, and I will practice {madLibArray[15]}. Parents need " +
                $"vacations more than kids because parents are always very {madLibArray[16]} and because they have to work {madLibArray[17]}" +
                $"hours every day all year making enough {madLibArray[18]} to pay for the vacation.");

        }
    }
}
