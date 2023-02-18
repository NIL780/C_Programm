Console.Write ("Введите имя пользователя: ");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "maria")
{
    Console.WriteLine ("Ура, это же Маша");
}
else
{
    Console.Write("Hello! ");
    Console.WriteLine(UserName);
}