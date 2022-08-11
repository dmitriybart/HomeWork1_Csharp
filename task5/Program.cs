// Показать числа от -N до N

Console.Write("Введите начало интервала(отрицательное число): ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите конец интервала: ");
int secondNumber = int.Parse(Console.ReadLine());

while (firstNumber < secondNumber+1)
{
    Console.Write(firstNumber + " ");
    firstNumber++;
}

