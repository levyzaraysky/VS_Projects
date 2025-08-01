// int[,] box = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
// int n = int.Parse(Console.ReadLine());

// // Filling
// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         box[i, j] = int.Parse(Console.ReadLine());
//     }
// }

// // Printing

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("UnSquared");
// Console.ForegroundColor = ConsoleColor.White;

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         Console.Write($"{box[i, j],6}");
//     }
//     Console.WriteLine();
// }

// // Square  

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         if (box[i, j] == n)
//         {
//             box[i, j] = n * n;
//         }
//     }
// }

// // Print

// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine("Sqruared");
// Console.ForegroundColor = ConsoleColor.White;

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         Console.Write($"{box[i, j],6}");
//     }
//     Console.WriteLine();
// }   