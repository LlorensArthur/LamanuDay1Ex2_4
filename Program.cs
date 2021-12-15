string login;
string password;
Console.WriteLine("Veuillez entrer votre identifiant");
login = Console.ReadLine();
Console.WriteLine("Veuillez entrer votre mot de passe");
password = Console.ReadLine();
switch (login, password)
{
    case ("Manu","lamanu"):
        Console.WriteLine("Bienvenue à la Manu.");
        break;
    default:
        Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        break;
}