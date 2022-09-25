// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number > 99)
{
    while (number > 999)
    {
        number = number/10;
    }
    Console.WriteLine("Третья цифра заданного числа: " + number % 10);
}

else
{
    Console.WriteLine("В данном числе нет третьей цифры");
}