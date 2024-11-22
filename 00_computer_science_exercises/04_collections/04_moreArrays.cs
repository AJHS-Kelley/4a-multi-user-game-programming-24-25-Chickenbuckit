// Casey Boyce, Even More Arrays, YAY, v0.1
using System;
using System.Collections;
using System.Linq;
class moreArrays {
  static void Main() {
    string[] colors = {"Garnet", "Pearl", "Amathist", "Rose pink", "Steaven"};
    // Looping arrays -- the old way
    for (int i = 0; i < colors.Length[i]; i++)
    {
        Console.WriteLine(colors[i]);
    }
    // Looping arrays -- but the good cuich style
    foreach (string i in colors)
    {
        Console.WriteLine(i);
    }
	  // PRACTICE With looping arrays
    int[] Numbers = {-1234, -457, -23, 9, 1, 234, 623, 732, 7854, 6782};
        foreach (int i in Numbers)
    {
        Console.WriteLine(i);
        if (i % 2 == 0)
        {
        	Console.WriteLine("This Number Is Even");
        }
        else
        {
        	Console.WriteLine("This Number Is Odd");
        }
    }
    //Multy dimentional arrays
    // this class only for 2 dimentions
    int[,] nums = {{2, 4, 6}, {-1, 0, 1}};
    // accecing the elements in 2d arrays
    Console.WriteLine(nums[0,1]);
    Console.WriteLine(nums[1,1]);
    // changing elements in 2d arrays
    nums = [1,2] = 9001;
    // Chang any e3lement from the first array
    num = [0,0] = 43110
    // Looping through 2d arrays
    foreach (int i in nums)
    {
      Console.WriteLine(i);
    }
    // Looping through 2d arrays -- HARDER (For no reason)
    for (int i; i < nums.GetLength(0); i++)
    {
      for (int j; j < nums.GetLength(1); j++)
      {
        Console.WriteLine(nums[i,j])
      }
    }
   } //NEVER DELETE, also only three spaces needed
} //NEVER DELETE, also always touching left side