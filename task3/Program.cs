// Найти максимальное из трех чисел
Console.Write("Введите первое число: ");
double firstNumber = double.Parse (Console.ReadLine());

Console.Write("Введите второе число: ");
double twoNumber = double.Parse (Console.ReadLine());

Console.Write("Введите третье число: ");
double threeNumber = double.Parse (Console.ReadLine());

double max = firstNumber;

if (firstNumber > max) max = firstNumber;
if (twoNumber > max) max = twoNumber;
if (threeNumber > max) max = threeNumber;

Console.Write("Максимальное число = ");
Console.WriteLine(max);

