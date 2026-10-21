object dato = "SENA";
if (dato is string)
{
    string s = (string)dato;
    Console.WriteLine("Texto de " + s.Length + " caracteres");
}
else if (dato is bool)
{
    bool b = (bool)dato;
    Console.WriteLine("Booleano: " + b);
}
else if (dato is int)
{
    int i = (int)dato;
    Console.WriteLine("Entero: " + i);
}
else if (dato is double)
{
    double d = (double)dato;
    Console.WriteLine("Decimal: " + d);
}
else
{
    Console.WriteLine("Tipo no reconocido");
}