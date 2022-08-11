// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число меньше 1000: ");
int userNumber = int.Parse (Console.ReadLine());
if (userNumber < 100)
{
    Console.Write("Третьей цифры в числе нет!");
    
}
else
{
    int programNumber = userNumber%10;
    Console.Write("Третья цифра числа " + userNumber + " равна " + programNumber);
}

