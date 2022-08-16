Console.WriteLine("Введите ваше имя ");
string usernane = Console.ReadLine();
if(usernane.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(usernane);
}

