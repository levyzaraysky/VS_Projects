// string word = Console.ReadLine().ToLower();
// int con = 0;

// // Check how long spaceless word will be
// for (int i = 0; i < word.Length; i++)
// {
//     if (word[i] != (char)32)
//     {
//         con++;
//     }
// }
// // Create Spaceless array
// string[] words = new string[con];
// // Reset counter
// con = 0;

// // Fill spaceless array
// for (int i = 0; i < word.Length; i++)
// {
//     if (word[i] != (char)32)
//     {
//         words[con] = word[i].ToString();
//         con++;
//     }
// }


// string result = String.Join("", words); // Make unflipped string
// Array.Reverse(words); // Flip the spaceless array
// string resultflip = String.Join("", words); // Make flipped string
// // Check if it is the same
// if (resultflip == result)
// {
//     Console.WriteLine($"{result} is a palindrome");
// }