// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse (Console.ReadLine());
if (numberDay<8)
{
if (numberDay == 1)
{
    Console.WriteLine("Это понедельник");
}
if (numberDay == 2)
{
    Console.WriteLine("Это вторник");
}
if (numberDay == 3)
{
    Console.WriteLine("Это среда");
}
if (numberDay == 4)
{
    Console.WriteLine("Это четверг");
}
if (numberDay == 5)
{
    Console.WriteLine("Это пятница");
}
if (numberDay == 6)
{
    Console.WriteLine("Это суббота");
}
if (numberDay == 7)
{
    Console.WriteLine("Это воскресенье");
}
}
else
{
    Console.WriteLine("Введите число меньше или равно 7 ");
}