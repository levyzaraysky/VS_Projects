// int[,] box = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

// // Filling
// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         box[i, j] = int.Parse(Console.ReadLine());
//     }
// }

// Console.WriteLine("What coulum to sort?");
// int coulum = int.Parse(Console.ReadLine())-1;

// // Printing

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("Unsorted");
// Console.ForegroundColor = ConsoleColor.White;

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         Console.Write($"{box[i, j],6}");
//     }
//     Console.WriteLine();
// }

// // Sort

// for (int i = 1; i < box.GetLength(0); i++)
// {
//     if (box[i, coulum] < box[i-1, coulum])
//     {
//         int temp = box[i, coulum];
//         box[i, coulum] = box[i-1, coulum];
//         box[i-1, coulum] = temp;
//     }
// }


// // Print

// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("Sorted");
// Console.ForegroundColor = ConsoleColor.White;

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(coulum); j++)
//     {
//         Console.Write($"{box[i, j],6}");
//     }
//     Console.WriteLine();
// }