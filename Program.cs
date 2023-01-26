//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine ("Введите число A");
Console.WriteLine ("Введите число B");

int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);

if (numA > numB)

{
    Console.WriteLine($"{numA} большее число");
}

else{
    Console.WriteLine($"{numB} большее число");
}