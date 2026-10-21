string usuario = Console.ReadLine();
if (usuario != "aprendiz")
    Console.WriteLine("Usuario no encontrado");
else
{
    string clave = Console.ReadLine();
    if (clave == "Sena2026")
        Console.WriteLine("Bienvenido");
    else
        Console.WriteLine("Contraseña incorrecta");
}