string dia = Console.ReadLine().Trim().ToLower();
string r = Console.ReadLine().Trim().ToLower();
bool estudiante = (r == "si" || r == "sí" || r == "s" || r == "true");
int precio;
if (dia == "martes")
    precio = 7000;
else if (dia == "sábado" || dia == "sabado" || dia == "domingo")
    precio = 15000;
else if (estudiante)
    precio = 9000;
else
    precio = 12000;
Console.WriteLine("$" + precio.ToString("N0"));