//Collections example, Casey Boyce, v0.3
using System;
using System.Linq;
using System.Collections;
class Collections {
  static void Main() {
    /*
in C# an collections is known as an ARRAY.
-- Each item in the array is known as an element
-- Number of elements in the array cannot be changed
-- Contence of each elements can be changed
-- Arrays are ordered, meaning each items has a fixed position.
-- Position of the element is called an INDEX
-- First element index is 0
    */
        // Declaring  and defining an array
    string[] breakfastFoods = {"Cereal", "Bacon", "Pancakes", "Milk"};
    int[] testScore = {15, 64, 80, 90, 100};
    double[] GPA = {0.31D, 2.37D, 1.75D, 4.00D};
        // Print array contents -- All elements on a single line
    Console.WriteLine("The elements of each array are:\n");
    Console.WriteLine("Breakfast foods:\n" + String.Join(",", breakfastFoods));
    Console.WriteLine();// Print an empty line at end
        // Print array contents -- All elements on sepret lines
    Console.WriteLine("The elements of each array are:\n");
    Console.WriteLine("Breakfast foods:\n" + String.Join("\n", breakfastFoods));
    Console.WriteLine();// Print an empty line at end
        // How long is my array AKA deturmining the length
    Console.WriteLine("The length of the breakfastFoods array is: " + breakfastFoods.Length);
    // .Length is also known as a PROPERTY of the array
        // Accessing elements in the array with the index.
        Console.WriteLine("the first element in breakfastFoods is: " + breakfastFoods[0]);
        Console.WriteLine("the first element in testscore is: " + testScore[1]);
        Console.WriteLine("the first element in GPA is: " + GPA[2]);
   } //NEVER DELETE, also only three spaces needed
} //NEVER DELETE, also always touching left side