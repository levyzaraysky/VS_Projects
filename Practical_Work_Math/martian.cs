using System;
using System.Formats.Asn1;

class main {
    public static void Main (string[] args) {
        Console.WriteLine("How many Earth years?");
        int earth = int.Parse(Console.ReadLine());
        Console.WriteLine($"{earth} Earth years is {earth*365/687} Martion Years.");
    }
}