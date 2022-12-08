// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter number :");
string enterNum = Console.ReadLine();
int dayNum = Convert.ToInt32(enterNum);

if(dayNum == 6 || dayNum == 7)
{
    Console.WriteLine("Это день выходной: Да ");
}
else
{
    if(dayNum < 0 || dayNum > 7)
    {
       Console.WriteLine("Это не день недели."); 
    }
    else
    {
       Console.WriteLine("Это день выходной: Нет "); 
    }
} 
