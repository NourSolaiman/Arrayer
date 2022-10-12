using System.Collections.Immutable;

namespace Arrayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intPick = 1;

            //Initerar en String Array
            string[] strColors = { "Red", "Green", "Blue", "Yellow" };
            Console.WriteLine(strColors[intPick + 1]);

            //Ändrar värdet i index-position 2
            strColors[2] += "Purple";
            Console.WriteLine(strColors[2]);

            //Initiera en Int Array med bestemd storlek, dock utan element
            int[] intScore = new int[5];

            //Skapar ett objekt av Klassen Random
            Random rnd = new Random();

            //Insert värden till array
            intScore[0] = 2;
            intScore[1] = 3;
            intScore[2] = intScore[0] + intScore[1];
            intScore[3] = intPick;
            intScore[4] = rnd.Next(10) + 1;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                intScore[0], intScore[1], intScore[2], intScore[3], intScore[4]);

            //Sortera Array i nummerordning
            Array.Sort(intScore);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                intScore[0], intScore[1], intScore[2], intScore[3], intScore[4]);

            //Längd samt högsta och mintsa värde av Int array
            Console.WriteLine(intScore.Length);
            Console.WriteLine(intScore.Max());
            Console.WriteLine(intScore.Min());
            Console.WriteLine(intScore.Sum());

            //Först och sista order i bokstavsordning av String array
            //Min är först i boksvastordning
            Console.WriteLine(strColors.Min());
            Console.WriteLine(strColors.Max());
        }
    }
}