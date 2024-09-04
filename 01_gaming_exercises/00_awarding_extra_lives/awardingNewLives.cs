// Alexandra Sculley, 9/04/2024, v0.0

using System;
class template {
  static void Main() {
    int hearts = 3;
    Console.WriteLine("Type your score 10,000 through 500,000!");
    int score = int.Parse(Console.ReadLine());

    if (score >= 100000)
    {
        hearts += 3;
        Console.WriteLine("You have received three extra lives! Lives: " + hearts);
    }
    else if (score > 10000)
    {
        hearts += 2;
        Console.WriteLine("You have received two extra lives! Lives: " + hearts);
    }
    else if (score == 10000)
    {
        hearts += 1;
        Console.WriteLine("You have received one extra life! Lives: " + hearts);
    }
    else
    {
        Console.WriteLine("That is not a valid score!");
    }
  }
}
