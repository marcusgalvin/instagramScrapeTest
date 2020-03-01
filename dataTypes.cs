using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int intTwo;
        double dub;
        string str;
        // Read and save an integer, double, and String to your variables.
        intTwo = Convert.ToInt32(Console.Readline());
        dub = Convert.ToDouble(Console.ReadLine());
        str = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + intTwo);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", (d + dub)));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + str);
        // The 's' variable above should be printed first.

    }