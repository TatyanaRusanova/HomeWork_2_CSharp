//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int x = num;

while (x > 999)
{
    x = x / 10;
}
if (x > 99)
{
    x = x % 10;
    Console.WriteLine($"Третей цифрой числа {num} является {x}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
