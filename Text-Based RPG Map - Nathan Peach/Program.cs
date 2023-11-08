using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG_Map___Nathan_Peach
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };
        static int width = map.GetLength(1);
        static int height = map.GetLength(0);
        // usage: map[y, x] <--- coordinates start at 0,0 and not 1,1; no negative coordinates. To find [3,4], you would first move down to the fourth tile, then move to the fifth right tile.

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static void Main(string[] args)
        {
            //DisplayMap();
            DisplayMap(2);
            Console.ReadKey(true);
        }
        static void DisplayMap()//Unscaled version
        {
            Console.WriteLine("+------------------------------+");//Hard-coded for now because the map is unscaled
            for (int x = 0; x <= width - 1; x++)
            {
                for (int y = 0; y <= height - 1; y++, Console.WriteLine("|"))
                {
                    Console.WriteLine("|");
                    Console.SetCursorPosition(x + 1, y + 1);
                    Console.Write(map[y, x]);
                }
            } 
            Console.WriteLine("+------------------------------+");
        }
        //The display of the map is offset by Y+1 and x+1 to make space for the border. The top and bottom borders are placed outside of the for loops, and the
        //side borders are integrated into the loops. 
        //
        static void DisplayMap(int scale)//Scaled version
        {
            Console.Write("+");
            for (int scaling = 0;scaling < scale; scaling ++)
            {
                Console.Write("------------------------------");
            }
            Console.WriteLine("+");
            for (int x = 0; x <= (width)- 1; x++)
            {
                for (int y = 0; y <= (height) - 1; y++, Console.WriteLine("|"))
                {
                    Console.WriteLine("|");
                    Console.SetCursorPosition(x + 1, y + 1);
                    Console.Write(map[y, x]);
                }
            }
            Console.Write("+");
            for (int scaling = 0; scaling < scale; scaling++)
            {
                Console.Write("------------------------------");
            }
            Console.WriteLine("+");
        }
    }
}
