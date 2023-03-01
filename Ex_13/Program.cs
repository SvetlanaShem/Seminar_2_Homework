Console.Clear();

Console.Write("Введите целое число: ");
int userNumber;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Ошибка ввода");
}
string userNumberText = Convert.ToString(userNumber);
if (userNumberText.Length>2)
{
    Console.WriteLine($"Третья цифра числа {userNumber} - {userNumberText[2]}");
}
else
{
Console.WriteLine($"Третьей цифры в числе {userNumber} нет");
}
