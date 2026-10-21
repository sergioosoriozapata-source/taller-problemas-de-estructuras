string rol = Console.ReadLine().Trim().ToLower();
int hora = int.Parse(Console.ReadLine());
bool permitido = false;
if (rol == "admin")
    permitido = true;
else if (rol == "instructor" && hora >= 6 && hora <= 21)
    permitido = true;
else if (rol == "aprendiz" && hora >= 6 && hora <= 18)
    permitido = true;
if (permitido)
    Console.WriteLine("Acceso permitido");
else
    Console.WriteLine("Acceso denegado");