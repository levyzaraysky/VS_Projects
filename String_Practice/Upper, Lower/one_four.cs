// using System.ComponentModel.DataAnnotations;

// static void number1()
// {
//     Console.WriteLine(Console.ReadLine().ToUpper());
// }

// static void number2()
// {
//     Console.WriteLine(Console.ReadLine().ToLower());
// }

// static void number3()
// {
//     string word = Console.ReadLine();
//     int con = 0;
//     string[] split = word.Split("");
//     for (int i = 0; i < split.Length; i++)
//     {
//         if (split[i].ToUpper() != split[i])
//         {
//             con++;
//         }
//     }
//     if (con == split.Length)
//     {
//         Console.WriteLine("This entire string consists of upper letters!");
//     }
//     else
//     {
//         Console.WriteLine("This entire string does not consist of upper letters!");
//     }
// }

// static void number4()
// {
//     string word = Console.ReadLine();
//     int con = 0;
//     string[] split = word.Split("");
//     for (int i = 0; i < split.Length; i++)
//     {
//         if (split[i].ToLower() != split[i])
//         {
//             con++;
//         }
//     }
//     if (con == split.Length)
//     {
//         Console.WriteLine("This entire string consists of upper letters!");
//     }
//     else
//     {
//         Console.WriteLine("This entire string does not consist of upper letters!");
//     }
// }

// static void number5()
// {
//     string word = Console.ReadLine().ToLower();
//     word.Replace(word[0], char.Parse(word[0].ToString().ToUpper()));

// }

// static void ask()
// {
//     Console.WriteLine("Which program do you want to run? \n1: Make upper \n2: Make lower \n3: Check if upper \n4: Check if lower \n5: Correct case");
//     string choice = Console.ReadLine();
//     if (choice == "1")
//     {
//         number1();
//     }

//     else if (choice == "2")
//     {
//         number2();
//     }

//     else if (choice == "3")
//     {
//         number3();
//     }

//     else if (choice == "4")
//     {
//         number4();

//     }
    
//     else if (choice == "5")
//     {
//         number5();
//     }

//     else
//     {
//         ask();
//     }
// }

// ask();