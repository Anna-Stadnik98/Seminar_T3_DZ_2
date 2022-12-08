// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter number :");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if(num > 99 && num < 1000)
{
    int Number = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра в числе {num} -> {Number}");
}
else
    Console.WriteLine($"Число {num} не трёхзначное ");
