// int a = 5;
// if (a == 5)
// {
//     Console.WriteLine("Number is five");
// }

// bool word = true;
// if (word)
// {
//     Console.WriteLine("Word is true");
// }

// if (a > 6)
// {
//     Console.WriteLine("A is greter");
// }
// else
// {
//     Console.WriteLine("A is less");
// }

// if (a > 4 && word)
// {
//     Console.WriteLine("Both are right");
// }

// if (a > 9 || word)
// {
//     Console.WriteLine("At least one is right");
// }

Console.Write("Enter role: ");
string role = Console.ReadLine();
if (role == "admin")
{
    Console.Write("Enter your name: ");
    string user_name = Console.ReadLine();
    Console.Write("Enter {0} age: ", user_name);
    short age = Convert.ToInt16(Console.ReadLine());

    if (age <= 0 || age > 99)
    {
        Console.Write("Enter {0} age: ", user_name);
        age = Convert.ToInt16(Console.ReadLine());
    }

    if (age <= 0 || age > 99)
    {
        Console.WriteLine("Error");
        age = 0;
    } else {
        Console.WriteLine("User's age is: " + age);
    }
}
else
{
    Console.WriteLine("No permits");
}
