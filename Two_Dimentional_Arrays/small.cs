// int[,] box = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

// // Filling
// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         box[i, j] = int.Parse(Console.ReadLine());
//     }
// }

// // Printing

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         Console.Write($"{box[i, j],6}");
//     }
//     Console.WriteLine();
// }

// int min = box[0, 0];
// int coordx = 0;
// int coordy = 0;

// // Minimum

// for (int i = 0; i < box.GetLength(0); i++)
// {
//     for (int j = 0; j < box.GetLength(1); j++)
//     {
//         if ((box[i, j] < min))
//         {
//             min = box[i,j];
//             coordx = i;
//             coordy = j;
            
//         }
//     }
// }

// Console.WriteLine($"The Smallest Number is {min}");
// Console.WriteLine($"Position: {coordx},{coordy}");

