int[,] box = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
int con = 0;

// Filling
for (int i = 0; i < box.GetLength(0); i++)
{
    for (int j = 0; j < box.GetLength(1); j++)
    {
        box[i, j] = int.Parse(Console.ReadLine());
    }
}

// Printing

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Unfived");
Console.ForegroundColor = ConsoleColor.White;

for (int i = 0; i < box.GetLength(0); i++)
{
    for (int j = 0; j < box.GetLength(1); j++)
    {
        Console.Write($"{box[i, j],6}");
    }
    Console.WriteLine();
}

// Five

for (int i = 0; i < box.GetLength(0); i++)
{
    for (int j = 0; j < box.GetLength(1); j++)
    {
        if (box[i, j] >= 5)
        {
            con += 1;
        }
    }
}

int[] mass = new int[con];
int k = 0;

for (int i = 0; i < box.GetLength(0); i++)
{
    for (int j = 0; j < box.GetLength(1); j++)
    {
        if (box[i, j] >= 5)
        {
            mass[k] = box[i, j];
            k++;
        }
    }
}

// Print

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Fived");
Console.ForegroundColor = ConsoleColor.White;

for (int i = 0; i < mass.GetLength(0); i++)
{
    Console.Write($"{mass[i]}  ");

    if (con == 0)
    {
        Console.WriteLine("There are no numbers greater or equal to 5");
    }
}   