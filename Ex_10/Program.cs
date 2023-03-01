Console.Clear();

Console.Write("Введите целое трехзначное число: ");
int userNumber;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Ошибка ввода");
}
int result = (userNumber / 10) % 10;
Console.WriteLine($"Вторая цифра числа {userNumber} {result}");
