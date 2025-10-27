string word = Console.ReadLine().Trim();
if (word.Contains(" "))
{
    word = word.Remove(word.Length / 2);
}
Console.WriteLine(word);