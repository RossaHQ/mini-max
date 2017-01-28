using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      string [] str_array = Console.ReadLine().Split(' ');

    long [] int_array = Array.ConvertAll(str_array,Int64.Parse);

    long array_max = int_array.Max();
    long array_min = int_array.Min();

    long min = int_array.Sum() - array_max;
    long max = int_array.Sum() - array_min;

    Console.WriteLine(min + " " + max);
           
           
    }
}