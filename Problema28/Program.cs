double compra = double.Parse(Console.ReadLine());
string r = Console.ReadLine().Trim().ToLower();
bool frecuente = (r == "si" || r == "sí" || r == "s" || r == "true");
int desc;
if (compra >= 500000)
    desc = 15;
else if (compra >= 200000)
    desc = 10;
else if (compra >= 100000)
    desc = 5;
else
    desc = 0;
if (frecuente && compra >= 100000)
    desc = desc + 5;
double total = compra * (1 - desc / 100.0);
Console.WriteLine("Compra: $" + compra.ToString("N0") + " | Descuento: " + desc + " % | Total: $" + total.ToString("N0"));