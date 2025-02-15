// using System;
// using System.Formats.Asn1;

// class main {
//     public static void Main (string[] args) {
//         int con = 0;
//         while (con < 3) {
//             Console.WriteLine("GET 3 IN A ROW. \n What is your favorite color? \n 1. Red, \n 2. Orange, \n 3. Yellow, \n 4. Green, \n 5. Blue, \n 6. Purple. \n");
//             string answer = Console.ReadLine().ToLower();

//             if (answer == "2" || answer.ToLower() == "orange") {
//                 con += 1;
//                 Console.WriteLine($"You are on {con} answers correct! \nThis answer is correct.");
//             }
//             else {
//                 Console.WriteLine("This answer is incorrect.");
//                 con = 0;
//             }
//             Console.WriteLine("What's this language? \n 1. C# \n 2. English \n 3. Java \n 4. Ingles \n 5. JavaScript \n 6. Malbolge \n 7. Whitespace \n 8. SNOBLE \n");
//             answer = Console.ReadLine().ToLower();

//             if (answer == "1" || answer.ToLower() == "english" || answer == "2" || answer.ToLower() == "ingles" || answer == "4") {
//                 con += 1;
//                 Console.WriteLine($"You are on {con} answers correct! \nYour are correct ");
//             }
//             else {
//                 Console.WriteLine("Incorect, Counter shall restart");
//                 con = 0;
//             }

//             Console.WriteLine("What is this? \n 1. Questionare \n 2. Test \n 3. Silly Thing \n 4. Very hard \n");
//             answer = Console.ReadLine().ToLower();  
            
//             if (answer == "1" || answer == "questionare" || answer == "very hard" || answer == "4") {
//                 con += 1;
//                 Console.WriteLine($"You are on {con} answers correct! \nCorrect!");
//             }
//             else {
//                 Console.WriteLine("Incorrect, Counter will go to 0");
//             }
//         }
//         Console.WriteLine("Congradulation you finally did it! 3/3");
            
//     }
// } 