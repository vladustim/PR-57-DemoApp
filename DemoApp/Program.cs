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

while (true)
{
    Console.Write("Введіть вік: ");
    var input = Console.ReadLine();
    if (input is null)
    {
        Console.WriteLine("Вік не введено.");
        return;
    }

    if (!int.TryParse(input, out int age) || age < 0)
    {
        Console.WriteLine("Вік має бути невід’ємним цілим числом.");
        continue;
    }

    string ageGroup = age >= 18 ? "повнолітня особа" : "неповнолітня особа";
    Console.WriteLine($"Вітаю {userName}! Ваш вік: {age}. Ви — {ageGroup}.");
    return;
}
