// string what = Console.ReadLine();
// int con = 0;
// bool first = false;
// bool last = false;
// for (int i = 0; i < what.Length; i++)
// {
//     if (what[i].ToString() == " " && what[i] == what[0] && i == 0)
//     {
//         con++;
//         first = true;
//     }

//     else if (what[i].ToString() == " " && what[i] == what[what.Length - 1] && i == what.Length - 1)
//     {
//         con++;
//         last = true;
//     }

//     else if (what[i].ToString() == " ")
//     {
//         con++;
//     }
// }
// if (first == true && last == false)
// {
//     Console.WriteLine(con);
// }

// else if (first == false && last == true)
// {
//     Console.WriteLine(con);
// }

// if (first == true && last == true)
// {
//     Console.WriteLine(con - 1);
// }

// if (first == false && last == false)
// {
//     Console.WriteLine(con+1);
// }


// // Or to use split()

// // string[] strings = what.Split(" ");
// // Console.WriteLine(strings.Length);