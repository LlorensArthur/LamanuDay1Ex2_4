const string registeredLogin = "Manu";
const string registeredPassword = "lamanu";
string userLogin;
string userPassword;
// L'utilisateur saisit ses identifiants
Console.WriteLine("Veuillez entrer votre identifiant");
userLogin = Console.ReadLine();
Console.WriteLine("Veuillez entrer votre mot de passe");
userPassword = Console.ReadLine();
// Vérification des identifiants
switch (userLogin, userPassword)
{
    case (registeredLogin, registeredPassword):
        Console.WriteLine("Bienvenue à la Manu.");
        break;
    default:
        Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        break;
}