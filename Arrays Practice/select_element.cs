int[] a = new int[int.Parse(Console.ReadLine())];
int count = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = int.Parse(Console.ReadLine());
    if (a[i] >= 888)
    {
        count++;

    }
}

int[] b = new int[count];

int j = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] >= 888)
    {
        b[j] = a[i];
        j++;
    }
}

Array.Sort(b);
Array.Reverse(b);

for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine(b[i]);
}