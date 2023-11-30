Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ksenia")
{
    Console.WriteLine("Мы так рады тебя видеть,Ksenia!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}