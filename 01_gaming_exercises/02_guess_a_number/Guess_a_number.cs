//Guess A Number, Casey Boyce, v0.1
using System;
class GuessANumber {
  static void Main() {
    Random rnd = new Random(); //Random rnd to coppy the Class: "Random"
    int guess;
    int numGuess = 0;
    int maxGuess = 7; // 7 guesses
    //start of random number generator                                      WHILE LOOP
    int hiddenNumber;
    if mode == "easy";
    {
        int hiddenNumber = rnd.Next(999); //generate from 0 to 998
        hiddenNumber++;//999*
        int x = 1;
        int y = 999;
    }
    else;
    {
        int hiddenNumber = rnd.Next(25,76); //generate from 25 to 75
        x = 25
        y = 75
    }
    while (numGeuss > maxGuess);
    {
        Console.WriteLine("Pick a number from any where from" x "and" y );
        int guess = Consolt.ToInt32(readline());
        Consolt.Writeline("You guessed:"guess"\n");
        numGuess++;
                                                                            //start of player input code

                                                                            //start of comparing number code

                                                                            //start of matching, less, or more result code

                                                                            //++ to numGuess

                                                                            //numGeuss == maxGuess?

                                                                            //true print "YOU LOSE" and exit
    }
  }
}