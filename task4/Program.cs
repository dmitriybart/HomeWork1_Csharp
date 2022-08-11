// Выяснить является ли число чётным

Console.Write("Введите любое число: ");
double number = double.Parse(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine(number + " - это число чётное");
}
else 
{
    Console.WriteLine(number + " - это число нечётное");

}