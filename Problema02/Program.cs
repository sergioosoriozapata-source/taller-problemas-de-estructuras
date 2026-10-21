double peso = double.Parse(Console.ReadLine());
double tarifa = 0;
if (peso <= 0)
{
    Console.WriteLine("Peso inválido");
}
else if (peso < 1)
{
    tarifa = 8000;
    Console.WriteLine("$" + tarifa.ToString("N0"));
}
else if (peso < 5)
{
    tarifa = 15000;
    Console.WriteLine("$" + tarifa.ToString("N0"));
}
else if (peso < 20)
{
    tarifa = 32000;
    Console.WriteLine("$" + tarifa.ToString("N0"));
}
else
{
    tarifa = 60000;
    Console.WriteLine("$" + tarifa.ToString("N0"));
}