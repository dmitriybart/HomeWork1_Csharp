// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine());

Console.Write("Задайте кратность: ");
int multipleNumber = int.Parse(Console.ReadLine());

if (userNumber%multipleNumber==0)
{
    Console.Write("Число " + userNumber + " кратно числу " + multipleNumber ); 
}
else
{

Console.WriteLine("Число " + userNumber + " не кратно числу "  + multipleNumber + ", остаток равен: " + userNumber%multipleNumber);
}