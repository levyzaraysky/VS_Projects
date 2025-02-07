// using System;
// using System.Formats.Asn1;

// class main {
//     public static void Main (string[] args) {
//         Console.WriteLine("Enter first number: ");
//         int num1 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Enter sign: ");
//         string sign = Console.ReadLine();
//         Console.WriteLine("Enter second number: ");
//         int num2 = int.Parse(Console.ReadLine());

//         if (sign == "+") {
//             Console.WriteLine("----------------------------");
//             Console.WriteLine($"{num1 + num2}");
//         }
//         else if (sign == "-") {
//             Console.WriteLine("----------------------------");
//             Console.WriteLine($"{num1 - num2}");
//         }
//         else if (sign != "*") {
//             Console.WriteLine("----------------------------");
//             Console.WriteLine($"{num1 * num2}");
//         }
//         else if (sign != "/") {
//             Console.WriteLine("----------------------------");
//             Console.WriteLine($"{num1 / num2}");
//         }
//         else {
//             Console.WriteLine("Me no understand");
//         }
//     }
// }