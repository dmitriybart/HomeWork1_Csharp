// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int firstNumber = new Random().Next(10,100); 
Console.WriteLine("Выпавшее число = " + firstNumber);
int numberA = firstNumber/10;
int numberB = firstNumber%10;

if (numberA > numberB)
{
    Console.Write("Наибольшая цифра Вашего числа = " + numberA);
}
else
{
     Console.Write("Наибольшая цифра Вашего числа = " + numberB);
}