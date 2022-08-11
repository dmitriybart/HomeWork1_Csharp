// Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int userNumber = int.Parse (Console.ReadLine());
int programNumber = userNumber/10;
int secondNumber = programNumber%10;
Console.WriteLine(secondNumber + " - это вторая цифра в Вашем числе");
