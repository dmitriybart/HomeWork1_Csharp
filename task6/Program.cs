// Показать последнюю цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int userNumber = int.Parse(Console.ReadLine());
int threeNumber = userNumber%10;
Console.WriteLine(threeNumber + " - это последняя цифра Вашего числа");
