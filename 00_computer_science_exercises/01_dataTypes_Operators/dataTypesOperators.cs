// Data Types and Operators, Alexandra Sculley, v0.4
// This file stands to go over the basic functions of data types and operators in C#.
using System;
class DataTypesOperators {
  static void Main() {
    // This is a comment, it gets ignored.
    // aklsdjalksdjalkfhlakhaksdfjaldjasdladj

    /*
    This is still a comment.

    */

    // DATA TYPES
    // C# is STATICALLY TYPED -- once a variable has a data type, it cannot change.
    
    // Float - float -- decimal numbers, +/- including 0.0
    
    // Double - double -- decimal numbers, +/- including 0.0 <-- MOST COMMONLY USED DECIMAL.

    // Integer - int -- whole numbers, +/- including 0. 
    
    // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE.
    // DECLARING (CREATING VARIABLES)
    // Method #1 - Declared but not assigned.
    // dataType variablename;
    
    int oneCount; 
    double twoCount;

    // Method #2 - Declare and Assign.

    int oneCount2 = 1;
    double twoCount2 = 2.22D;

    // Strings -- Collection of letters, numbers, and speciakl characters.
    string stringCount = "Little string buddy.";

    // Boolean -- bool - True or False values
    bool oneBool = true;
    bool deathBlock = false;
    bool hasDoorKey = true;


    // Character -- char - A single character.

    char myLetter = 'A';

    // ASSIGNING VALUES AFTER DECLARATION.

    oneCount = 5;
    oneBool = false;
    hasDoorKey = false;
    twoCount = 0.00111;

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine(oneCount);
    Console.WriteLine(twoCount);

    // PRINTING EXPRESSIONS TO THE CONSOLE TERMINAL
    Console.WriteLine(oneCount - 25);
    Console.WriteLine(twoCount2 + 3.869);

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine(oneCount);
    Console.WriteLine(twoCount);

    // OPERATORS -- ARITHEMETIC 

    int newOneCount = oneCount + oneCount2;
    double newTwoCount = twoCount + twoCount2;

    double fancyDoubleCount = oneCount + twoCount;

    // Subtraction
    int food = oneCount - 5;

    // Division
    int scribble = 3 / oneCount;

    // Multiplication
    int scrabble = 2 * oneCount2;

    // Modulus -- Divides, then returns the remainder.
    // Mostly commonly used to determine even or odd.
    food = oneCount % 2;

    int students = 10;
    int classes = 2;
    int studentsInClass;

    studentsInClass = students % classes;

    // Increment/Decrement -- Most frequently used in LOOPS
    int x = 0;
    x++; // what is x equal to now
    // Increment ++ adds 1 to the current balue and puts a new value into the bucket
    x--;
    //Decrement -- Subtracts by 1 fromt he current value and puts the new value into the bucket

    // Special Assignment Operator
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    // Take current value, preform the calculation, put the new value into the bucket

    // Comparison Operators
    // Evaluate the expression, return true or false
    int y = 5; 
    int z = 3;

    // // Is-equal == is the valye on the left equal to the value on the right
    // Console.WriteLine(y == z);

    // // not equal to != is the value on the left not equal to the value on the right
    // Console.WriteLine(y != z);

    // // Greater than > Is the value on the left greater than the value on the right
    // Console.WriteLine(y > z);

    // // Less than < Is the value on the left less than the value on the right
    // Console.WriteLine(y < z);
    
    // // Greater than or Equal to >= Is the value on the left greather than OR equal to the value on the right
    // Console.WriteLine(y >= z);

    // // Less than or Equal to <= Is the value on the left less than OR equal to the value on the right
    // Console.WriteLine(y <= z);

    // // Logical Operators
    // int b = 6;
    // double d = 7.60;
    // string hungry = "yes"

    // // Logical and && -- all statements must be true.
    // Console.WriteLine(b > 1 && d != 2.50) // True because b is greater than 1 and d is NOT equal to 2.50
    // Console.WriteLine(b < 1 && d == 7.60) // False because b is not less than 1.

    // // Logical or || -- Atleast one statement has to be true.
    // Console.WriteLine(b > 1 || d == 5.80) // True statement because b is greater than one
    // Console.WriteLine( b == 1 || d < 6.00) // False because neither statement is true
    // // Check for the statement most likely to be true first

    // // Logical Not ! -- Returns the opposite value of the expression.
    // Console.WriteLine(b < -3) // This returns True because the original return is False.
    // Console.WriteLine(d > 5.34) // This returns False becayse the original return is True.





  }
}
