// Data types and operators, Casey Boyce, V0.7
using System;
class DataTypesOperaters {
  static void Main() {
    // this is a coment, it gets ignored
    //pkujsehdrfpgikuqgeroituygf2bqolirgfopaweifuyvgolqirgb 
    /*
                            LA
    this is a comment but   AR
                            GE
    */

    //Data types
    //C# is STATICLY typed -- onece a varitable has a data type it cant be changed
    //Float -- float -- decimal number, decimal +/- including 0.0
    //Double -- double -- decimal number, +/- including 0.0
    //intagers -- int -- whole numbers +/- including 0
    //varitables are 'buckets' that have names to store data insides
    //declaring (creating varitables)
    //method 1 -- declared but no value
    //datatype varitableName;
    int triangle;
    double doubleTrangle;
    //declare and assign
    int triangle2 = 56;
    double doubleTrangle2 = 112D;
    //Strings -- colections of letters, nubers, spechal caricters, ect.
    string sentence = "이것은 문장이다";
    //boolean -- bool -- true or flase statment
    bool trueOrFalse = true;
    bool fireBad = false;
    bool paulFound = false;
    //character -- char -- a single charicter
    char letterA = "A";
    //assigning values after decleration
    "triangle" = 14;
    "doubleTrangle" = 28;
    "firebad" = true;
    //printing varitables to the consolt table
    Console.WriteLine(triangle);
    Console.WriteLine(doubletriangle);
    Console.WriteLine(triangle2);
    Console.WriteLine(doubletriangle2);
    Console.WriteLine(sentence);
    //operators -- arithmic
    int triangle3 = triangle + triangle2;
    double doubleTrangle3 = doubleTrangle + doubleTrangle2;
    double mixedtriangle3 = doubleTrangle3 + triangle3;
    //subtraction
    minusTriangle = triangle - triangle2;
    //division
    divisionDoubleTriangle = doubleTrangle / doubleTrangle2;
    //multiplication
    multiTriangle = triangle3 * doubleTrangle3;
    //Modulus -- divides then returns the REMAINDER
    remaningTriangle = multiTriangle % 2;
    //increacement / decreacement -- Most frequently used in loops
    int x = 0;
    x++;
    //adds one to current and replaces previos value
    x--;
    //subtract 1 form current and replaces previos value
    //Speasul assingment opperatos
    x += 1;
    x *= 1;
    x -= 1;
    x %= 1;
    //take current, calculate, replace
    //comparison operators
    //evaluate the expration, return TRUE OR FALSE
    int y = 5;
    int z = 3;
    //isw equal to == dose this thing on left mach the right                                                                                                                                                                                    Nothing Over Here                                                                      Here is Paul QMQ
    Console.WriteLine(y == z);
    //not equal to != it the value on right not match the right
    Console.WriteLine(y != z);
    //Greater than
    Console.WriteLine(y > z);
    //Greater than or equal to
    Console.WriteLine(y >= z);
    //less than
    Console.WriteLine(y < z);
    //less than or equal to
    Console.WriteLine(y <= z);
    //logical operators
    int b = 1;
    double c = 2.0D;
    string blueColor = "Blue";
    //logic and && -- all statements for trueness
    Console.WriteLine(b > 1 && c != 5.0D); // False
    Console.WriteLine(b == 1 && c != 10.0D); // False
    //if one expression is probobly false, check for it first
    Console.WriteLine(paulFound == true && triangle == 14);
    //logical OR || -- one must be true for is to be true
    Console.WriteLine(b == 1 || c != 10.0D); // True
    Console.WriteLine(b > 1 && c != 5.0D); // True as well
    Console.WriteLine(b == 2 || c >= 10.0D); // False
    //check for the statement that is mostlikly true first
    //logical NOT ! -- returns opuset of the result
    Console.WriteLine(b > -1);
    
    int age;
    if (age >= 0)
    {
      Console.WriteLine("Age data stored.\n");
    }
    else
    {
      Console.WriteLine("No age value detected. please review.\n");
    }
    //switch statements
    int day = 1
    switch(day)
    { case 1:
        Console.WriteLine("Today is Monday.\n");
        break;
      case 2:
        Console.WriteLine("Today is Tusday.\n");
        break;
      case 3:
        Console.WriteLine("Today is Wensday my dudes.\naaaaaAAAAAAAHHHHHHH!\n");
        break;
      case 4:
        Console.WriteLine("Today is Thersday.\n");
       break; 
      case 5:
        Console.WriteLine("Today is Friday.\n");
       break;
      case 6:
        Console.WriteLine("Today is Saturday.\n");
       break;
      case 7:
        Console.WriteLine("Today is Sunday.\n");
        break;
    }
    //Repating varitable
    //Loops are used to repeate instructions multiple times
    //while loops are like "musical chairs" in computer sciance
    //as long as thing is true then keep on keeping on
    //while loop syntax
    /*
    while (CONDITION_EXPRESTION)
    {
      Code goes here
    } 
    */
    // int z = 0;
    // while (z <= 100);
    // {
    //   Console.WriteLine(z);
    //   z++;
    // } 
    // //own code
    // int y = 100;
    // while (y >= 0);
    // {
    //   Console.WriteLine(y);
    //   y--;
    // } 
    //for loops are like playing go fish
    //you know how many cards in your hand
    //used when you know how many loops you need ahed of time
    /*
    for (statement_1;statement_2;statement_2)
    {
      code to run each time through loop.
    }
    statement_1 = code to run onece befor the loop starts
    statement_2 = conditional exprestion to check each time the loop reruns
    statement_3 = code to run after each loop
    Each 'run' through the loop is called an iteration
    */
    //counting to 10 with for loop
    for (int i = 0; i <= 10; i++)
    {
      Console.WriteLine(i);
    }
    }
}