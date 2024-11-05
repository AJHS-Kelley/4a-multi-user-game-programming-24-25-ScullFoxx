// Collections Sculley, Alexandra 11/5/2024, v0.0

using System;
class Collections {
  static void Main() {
    
/*
In C#, Collection is known as an ARRAY

-- Each item in the array is an Element
- the number of elements in an array cannot be changed
-- Contents of each element can change
-- Arrays are ordered, meaning each item has a fixed position
-- Position of an element is calledn an INDEX
-- First element in Index is 0
*/

// Declaring and Defining an ARRAY
string[] breakfastFoods = {"Waffles", "Sausages", "Eggs", "Muffins", "Poptarts"};
int[] testScores = {-35, 25, 53, 72, 100};
double[] GPA = {0.13D, 1.8D, 2.0D, 3.0D, 60.4D};

// Print Array Contents == All Elements on Single Line
Console.WriteLine("The Elements of each array are:\n");

Console.WriteLine("Here's all the breakfast we got kid. \n" + string.Join(",",breakfastFoods));
Console.WriteLine(); // Prints an empty line to the screen

Console.WriteLine("These are all of the test scores from our students: \n" + string.Join(",",testScores));
Console.WriteLine();

Console.WriteLine("Heres the following very confusing GPA's...: \n" + string.Join(",",GPA));
Console.WriteLine();

// Print Arrary Contents -- on seperate lines
Console.WriteLine("Here's all the breakfast we got kid. \n" + string.Join("\n", breakfastFoods));
Console.WriteLine(); // Prints an empty line to the screen

Console.WriteLine("These are all of the test scores from our students: \n" + string.Join("\n",testScores));
Console.WriteLine();

// How long is my array? Determining Array Length
Console.Writeline("The length of the breakfastfoods array is :" + breakfastFoods.Length);
//.Length is known as a property of the array

// Accessing elements in the array with the index
Console.WriteLine("The first element in breakfastFoods is : " + breakfastFoods[0]);
// Print the 2nd Element of the testscores and 3rd of the GPA
Console.WriteLine("The second element in testscores is: " + testScores[1]);
Console.WriteLine("The third element is GPA is: " + GPA[2]);

  } // DO NOT DELETE EVER, SHOULD BE 3 SPACES INDENT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN

