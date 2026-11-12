using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть ім’я: ");
var userName = Console.ReadLine()?.Trim();
if (string.IsNullOrEmpty(userName))
{
    Console.WriteLine("Ім’я не введено.");
    return;
}

Console.WriteLine($"Вітаю {userName}!");
