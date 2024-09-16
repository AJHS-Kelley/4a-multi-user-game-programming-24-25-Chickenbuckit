//Guess A Number, Casey Boyce, v0.1
using System;
class GuessANumber {
  static void Main() {
    Random rnd = new Random(); //Random rnd to coppy the Class: "Random"
    int guess;
    int numGuess = 0;
    int maxGuess = 7; // 7 guesses
    //start of random number generator                                      WHILE LOOP
    int secrateNumber;
    Console.WriteLine("Do You need \"easy\" mode or do you want \"hard\" mode\nYou have 7 guesses ether way");
    mode = Console.ToLower(readline());
    if (mode == "easy")
    {
        secrateNumber = rnd.Next(999); //generate from 0 to 998
        secrateNumber++;//999*
        int x = 1;
        int y = 999;
    }
    else
    {
        int secrateNumber = rnd.Next(25,76); //generate from 25 to 75
        x = 25;
        y = 75;
    }
    while (numGuess < maxGuess)
    {
        //start of player input code
        Console.WriteLine("Pick a number from any where from "+x+"  and  "+y+);
        int guess = Consolt.ToInt32(readline());
        Consolt.Writeline("You guessed: "guess"\n");
                                                                            //++ to numGuess
        numGuess++;
                                                                        //start of comparing number code
                                                                            //start of matching, less, or more result code
        if (guess < secrateNumber)
        {
            Console.WriteLine("To Low T-T\n");
        }
        else if (guess > secrateNumber)
        {
            Console.WriteLine("To High T-T\n");
        }
                                                                            //numGuess == maxGuess?
        else
        {
            Console.WriteLine("Correct ;3\n");
            break; // keword to stop a loop
        }
    }
                                                                                //if true print "YOU LOSE" and exit
    if (numGuess == maxGuess)
    {
        Console.WriteLine("                     YOU LOSE .u.")
    }
    else
    {
        Console.WriteLine("3Rr0R")
    }
    exit;
  }
}