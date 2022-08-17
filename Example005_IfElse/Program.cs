Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("ЭТО ЖЕ МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
// просто комментарий