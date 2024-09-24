// Sculley, Alexandra Strings C# v0.2

using System;
class Template {
    static void Main() {
        // In C# ALL STRINGS MUST BE DOUBLE-QUOTES " "
        string greeting = "Hello";
        string goodBye = "Adios";

        // In C# strings are treated like an OBJECT that has properties and methods
        // Properties -- things that describe the object such as length, values, data type, etc.
        // Methods -- built in functions related to that object

        // Length is an important property for strings
        Console.WriteLine(greeting.length);
        Console.WriteLine(goodBye.length);
         if (greeting.length > goodBye.length) {
            Console.WriteLine("Hello there");
         }

        // Useful String Methods

        Console.WriteLine(greeting.ToUpper()); // make entire string upper case
        Console.WriteLine(greeting.ToLower()); // make entire string lower case

        // String Concatenation "Con Cat Uh Nation"
        string comboString = greeting + goodBye;
        Console.WriteLine(comboString);

        // String Concatenation Method 2
        string comboString2 = string.Concat(greeting, goodBye,);
        Console.WriteLine(comboString2);

        // String Interpolation -- Subsituting variables into strings
        string comboString3 = $"My greeting is {greeting} and my goodbye is {goodBye}";
        Console.WriteLine(comboString3);

        // String Interpolation -- Subsituting variables into strings method 2
        COnsole.WriteLine("My greeting is " + greeting + " and my good bye is " + goodBye);

        // Accessing parts of strings
        // Index is a specific location of a character in a string
        // ALL string indexes start at 0

        Console.WriteLine(goodbye[0]); // Print the character at index 0
        Console.WriteLine(goodBye[4]); // Print the 5th character in your index

        // Where is it in my string?
        Console.WriteLine(greeting.IndexOf("y"));

        // Finding parts of a string
        string fullName = "Smarty McSmartPants";

        // What letter?
        int lastInitial = fullName.IndexOf("M");

        // Find the substring
        string lastName = fullName.Substring(lastInitial);

        // print it
        Console.WriteLine(lastName);
    }
}