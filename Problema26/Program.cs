char c = char.Parse(Console.ReadLine());
switch (c)
{
    case 'M':
        Console.WriteLine("Categoría M - Tarifa: $0");
        break;
    case 'A':
        Console.WriteLine("Categoría A - Tarifa: $12.000");
        break;
    case 'B':
        Console.WriteLine("Categoría B - Tarifa: $25.000");
        break;
    case 'C':
        Console.WriteLine("Categoría C - Tarifa: $38.000");
        break;
    default:
        throw new Exception("Categoría desconocida");
}