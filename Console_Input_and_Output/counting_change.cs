using System;
using System.Formats.Asn1;

class main {
    public static void Main (string[] args) {
        Console.WriteLine("How much do crystals cost?");
        int crystals_cost = int.Parse(Console.ReadLine());
        Console.WriteLine("How much gold do you have?");
        int gold = int.Parse(Console.ReadLine());
        Console.WriteLine("How much chrystals do you want to buy?");
        int crystals = int.Parse(Console.ReadLine()); 
        if  ((crystals_cost*crystals > gold) == false) {
            Console.WriteLine($"You spent {crystals_cost*crystals} and have {gold-(crystals_cost*crystals)}");
        }
        else {
            Console.WriteLine($"Your too broke.");
        }
    }
}
