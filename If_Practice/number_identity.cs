using System;
using System.Formats.Asn1;

class main {
    public static void Main (string[] args) {
        Console.WriteLine("Enter a Letter: ");
        string letter = Console.ReadLine();

        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" || letter == "y") {
            Console.WriteLine("This letter is a vowel");
        }
        else {
            Console.WriteLine("This letter is a constant");
        }
    }
} 