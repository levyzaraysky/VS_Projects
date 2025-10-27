string[] listofword = Console.ReadLine().Split(" ");

for (int i = 0; i < listofword.Length; i++)
{
    if (listofword[i].StartsWith(listofword[i][listofword[i].Length].ToString()) == true)
    {
        Console.WriteLine(listofword[i]);
    }
}
