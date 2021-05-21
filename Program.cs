using System;

Console.Write("First Name>");
string firstName = Console.ReadLine();

Console.Write("Last Name>");
string lastName = Console.ReadLine();

// string name = firstName + " " + lastName;
string name = ($"{firstName}   {lastName}");


for (int i = name.Length; i >= 1; i--)
{
    Console.Write(name[i - 1]);
}
// Console.WriteLine(lastName.Reverse());
