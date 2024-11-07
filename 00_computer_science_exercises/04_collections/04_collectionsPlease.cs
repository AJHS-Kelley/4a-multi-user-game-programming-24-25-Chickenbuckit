//Collections example, Casey Boyce, v0.7
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
    // string[] breakfastFoods = {"Cereal", "Bacon", "Pancakes", "Milk"};
    // int[] testScores = {15, 64, 80, 90, 100};
    // double[] GPA = {0.31D, 2.37D, 1.75D, 4.00D};

    /*
                // How long is my array AKA deturmining the length
    Console.WriteLine("The length of the breakfastFoods array is: " + breakfastFoods.Length);
    // .Length is also known as a PROPERTY of the array
        // Accessing elements in the array with the index.
    Console.WriteLine("the first element in breakfastFoods is: " + breakfastFoods[0]);
    Console.WriteLine("the first element in testScores is: " + testScores[1]);
    Console.WriteLine("the first element in GPA is: " + GPA[2]);
                // Shorcut to get the item at the end of an array
    Console.WriteLine("The last line of breakfastFoods is : " + breakfastFoods[breakfastFoods.length - 1]);
                // My example
    Console.WriteLine("The second last line of GPA is : " + GPA[GPA.length - 2]);
    // Changing elements in the array
    breakfastFoods[3] = "Pilk";
    testScores[2] = 32;
    GPA[0] = 2.91D;
                    // Print array contents -- All elements on a single line
                // comment for better run time
    Console.WriteLine("The elements of each array are:\n");
    Console.WriteLine("Breakfast foods:\n" + String.Join(",", breakfastFoods));
    Console.WriteLine();// Print an empty line at end
                // Print array contents -- All elements on sepret lines
    Console.WriteLine("The elements of each array are:\n");
    Console.WriteLine("Breakfast foods:\n" + String.Join("\n", breakfastFoods));
    Console.WriteLine();// Print an empty line at end
    */
    // Most common 3RR045 while using arrays
    // Console.WriteLine(breakfastFoods[99]); //ERROR name Index out of bounds -- You tried to contact an item that was not within range of the list, YOU CRIED FOR HELP... BUT NOBODY CAME
    // testScores[0] = "99" //  ERROR message "Cannot implicitly convert type ___ to ___ -- You tried to make an array have multple diffrent of varitables, your an idiot.
    // Common array methods -- ways to work with array data
    // sorting arrays
    // int[] intArr = {82, -19, 54, 0, 89612, 538, 9155}
    // string[] zooAnimals = {"Giraffe", "Penguin", "African wild dog", "Jackle", "Rabbit", "Lion", "Kakapo", "Elephant"}
    // Array.Sort(intArr)
    // Array.Sort(zooAnimals)
    // Console.WriteLine("The elements of each array are:\n");
    // Console.WriteLine("zooAnimals foods:\n" + String.Join("\n", zooAnimals));
    // Console.WriteLine();// Print an empty line at end
    // Array.Sort will sort the code -- if its an int or double array then it will be sorted into a least to greatest line, for strings it is a A-Z alphabetical sort
    // finding the MIN, MAX, and SUM for NUMARICAL ONLY arrays.
    // Console.WriteLine("The MINIMUM value for intArr is:" + intArr.Min());
    // Console.WriteLine("The MAXIMUM value for intArr is:" + intArr.Max());
    // Console.WriteLine("The SUM value for intArr is:" + intArr.Sum());

    // NEW LESSON

    // ARRAY List --> Bassicly an array but you can add/remove elements from.
    var exampleArrList = new ArrayList(); // create an array list
    // adding elements to an ArrayList use .Add()
    exampleArrList.Add(7);
    exampleArrList.Add("pronanceing worshashire sawce");
    exampleArrList.Add(false);
    exampleArrList.Add(1.25D);
    // Create ArrayList with values
    var exampleArrList2 = new ArrayList()
        {
            -56, "Boyce", "Flower", false, 25.25D, 2577267, 0.0D
        };
    // Console.WriteLine(exampleArrList(2));
    // Console.WriteLine(exampleArrList2(5));
    // Inserting to a position in the array
    // Use .Insert(index, value)
    // exampleArrList.Insert(2, true);
    // exampleArrList.Insert(5, "16");
    // .Remove(value) Removes the FIRST ACORENCE of an item from the ArrayList
    var newList = new ArrayList()
        {   
            -5, 2, -5, 4, 27, 367, 1263, 872, 34756, 84756
        };
    // Console.WriteLine(newList[0]);
    // newList.Remove(-5);
    // Console.WriteLine(newList[0]);
    // Deleting based on index number.
    // .Removeat(value) --> deletes the item at the spicific index
    // newList.Removeat(3);
    // Delete the first item
    // Console.WriteLine(0);
    // Delete the last item
    // Console.WriteLine(newList.Length - 1);
    // Remove a range of elements
    // .RemoveRange(firstIndex, lastIndex)
    // newList.RemoveRange(4, newlit.Length - 1);
    // Does the ArrayList contain value?
    // .Contains(value) if true then it is in the list, if false then no
    new playerInventory = ArrayList()
        {
            "Kile", "Finger", "Knife", "Raipier", "Burger", "Lighter"
        };
    Console.WriteLine(playerInventory.Contains("Ball"));
    Console.WriteLine(playerInventory.Contains("Kile"));
   } //NEVER DELETE, also only three spaces needed
} //NEVER DELETE, also always touching left side