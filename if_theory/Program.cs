using System;
using System.Formats.Asn1;

class main {
    public static void Main (string[] args) {
        Console.WriteLine("Enter Number");
        int number = int.Parse(Console.ReadLine());
        if (number%2 == 0) {
            Console.WriteLine("Even");
        }
        else {
            Console.WriteLine("Odd")
        }
    }
}