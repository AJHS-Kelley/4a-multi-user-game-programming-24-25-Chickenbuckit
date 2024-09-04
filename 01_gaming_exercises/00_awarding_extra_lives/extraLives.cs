//extra lives, Casey Boyce, v0.1
class extraLives {
  static void Main() {
    int livesRemaining = 3
    Console.WriteLine("You have " + livesRemaining + "lives left\n");
    Console.WriteLine("You gained points! But how many:\n");
    int points = Console.ToInt32(Console.ReadLine());
    Console.WriteLine("You gained points! But how many: " + points);
    if (points >= 10000)
    {
        livesRemaining --;
    }
    else if (points <= 10001 && points > 10000)
    {
        livesRemaining ++;
    }
    else if (points <= 10000)
    {
        livesRemaining --;
    }
    else
    {
        Console.WriteLine("3Rr0R");
    }
    Console.WriteLine("You have " + livesRemaining + "lives left\n");
  }
}