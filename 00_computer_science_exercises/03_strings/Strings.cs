//Strings, Casey Boyce, v0.2
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
    //usful concatenation "Con-Cat-Uh-Nation"
    string comboString = greeting + goodbye;
    consolt.WriteLine(comboString);
    //usful concatenation method #2
    string comboString2 = string.Concat(greeting, goodbye);
    consolt.WriteLine(comboString2);
    //string interpolation -- substatuting variatable into strings.
    string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}.\n"
    consolt.WriteLine(comboString3);
    //substitutiong Valuiables into strings method #2
    consolt.WriteLine("my greeting is " + greeting + "and my goodbye is " + goodbye + ".\n")
    //accessing parts of strings
    //index is a spicific location of a charicter in a string
    //strings always start a 0
    consolt.WriteLine(goodbye[0]);//Print the charictar with the 0 index.
    consolt.WriteLine(goodbye[4]);//Replace the 5 charictar with x
    //where is it in my string?
    consolt.WriteLine(greeting.IndexOf("e"));
    //finding parts of a string
    string fullName = "Justin Beaver";
    //what letter?
    int lastInitial = name.IndexOf("B");
    //finding the substring
    string lastName = fullName.Substring(lastInitial);
    //print it
    Console.WriteLine(lastName);
  }
}