Console.Clear();

Console.Write("Введите цифру, означающую день недели: ");
int userNumber;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out userNumber))
        break;
    Console.WriteLine("Ошибка ввода");
}
if (userNumber == 6 || userNumber == 7)
{
    Console.WriteLine("Этот день является выходным");
}
else if (userNumber>0 && userNumber<6)
{
    Console.WriteLine("Этот день не явялется выходным");
}
else
    Console.WriteLine("Эта цифра не означает день недели");