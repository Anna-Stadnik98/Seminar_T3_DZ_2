// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number :");
string enterNum = Console.ReadLine();
int num = Convert.ToInt32(enterNum);

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
else
{
    if(100 < num && num < 1000)
    {
       int Number = num % 10;
       Console.WriteLine($"Третья цифра {num} -> {Number}");
    }
    if(num > 1000)
    {
        int Num = num;
        while(Num > 1000)
        {
           Num /= 10; 
        }
        int result = Num % 10;
        Console.WriteLine($"Третья цифра {num} -> {result}");
    }
}
