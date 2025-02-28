using System;
class Program {
    public static void Main (string[] args) {
        Console.WriteLine("Write first number: ");
        int answer1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Write second number: ");
        int answer2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Write third number: ");
        int answer3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Arithmetic Mean is \n {(answer1+answer2+answer3)/3}");
    }
}