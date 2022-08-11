// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int userNumber = int.Parse(Console.ReadLine());
int numberC = userNumber%10;
int numberF = userNumber-numberC;
int numberB = numberF%100;
int numberA = userNumber-numberC-numberB;
int programNumber = numberA/10;
int doneNumber = programNumber+numberC;
Console.Write("Число без второй цифры Вашего числа: " + doneNumber);