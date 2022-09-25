// Задачв 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());
if (WeekDay > 0 && WeekDay < 8)
{
    if (WeekDay == 6 || WeekDay == 7)
    {
        Console.WriteLine("УРАААА!!! ВЫХОДНОЙ! =)");
    }
    else
    {
        Console.WriteLine("Будний день, иди работать!");
    }
}
else
{
    Console.WriteLine("Введен неверный номер дня недели.");
}
