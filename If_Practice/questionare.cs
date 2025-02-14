using System;
using System.Formats.Asn1;

class main {
    public static void Main (string[] args) {
        Console.WriteLine("What is your favorite color? \n 1. Red, \n 2. Orange, \n 3. Yellow, \n 4. Green, \n 5. Blue, \n 6. Purple. \n");
        string answer = Console.ReadLine();

        if (answer == "2" || answer.ToLower() == "orange") {
            Console.WriteLine("This answer is correct.");
        }
        else {
            Console.WriteLine("This answer is incorrect.");
        }
    }
} 