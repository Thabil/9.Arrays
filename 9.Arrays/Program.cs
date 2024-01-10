using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OneWayAttribute way of creating an array
            int[] luckyNumbers = { 4, 5, 8, 9, 3 };
            //When using Visual Studio
            //int[] luckyNumbers = { 4, 5, , 9, 3 }; // build error if there is no element/ number before a corma
            //int[] luckyNumbers = { 4, 5, 8, 9, }; //Console.WriteLine(luckyNumbers[4]); Index was outside the bounds of the array. last , ignored
            Console.WriteLine(luckyNumbers[0]);
            //if you wanna populate it later, the 5 is the size //string[] luckyNumbers = new string[5];

            //string[] friends = { "jim", "john", "peter" };
            string[] friends = new string[3];
            friends[0] = "Jim";
            friends[1] = "john";
            friends[2] = "Peter";
            Console.WriteLine(friends[0]);
        }
    }
}
