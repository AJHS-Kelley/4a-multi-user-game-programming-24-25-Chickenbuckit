//Strings, Casey Boyce, v0.0
using System;
class strings {
  static void Main() {
    //has to be "" arownd quotes
    string greeting = "Ello' lad, hows life been treatin' ya?\n";
    string goodbye  = "Oh, OK, Well see ya later mate.\n";
    //C# strings are treated lake an objects that has properteas and method
    //PROPERTIES -- things that discribe the object ex. length, size, data type, ext.
    //Methods -- built in frunctions related to functions
    //length is inportant
    consolt.WriteLine(greeting.length);
    consolt.WriteLine(goodbye.length);
    if (greeting.length > goodbye.length)
    {
        consolt.WriteLine("the greating is longer than the goodbye.\n")
    }
    else 
    {
        consolt.WriteLine("the Goodbye is longer than the greating.\n")
    }
    //usefull string methods
    consolt.WriteLine(greating.ToLower)//all to lowercase
    consolt.WriteLine(goodbye.ToUpper)//ALL TO UPPERCASE
  }
}