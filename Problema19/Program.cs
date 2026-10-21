int v = int.Parse(Console.ReadLine());
string sancion;
if (v < 0)
    sancion = "Lectura inválida";
else if (v <= 50)
    sancion = "Sin infracción";
else if (v <= 70)
    sancion = "Multa leve";
else if (v <= 90)
    sancion = "Multa grave";
else
    sancion = "Multa gravísima e inmovilización";
Console.WriteLine(sancion);