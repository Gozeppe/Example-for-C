Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")  // .ToLower - приводит всё введённое к нижнему регистру 
{
    Console.WriteLine("Ура, это же Маша");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}