char c = char.Parse(Console.ReadLine());
if (!char.IsLetter(c))
    Console.WriteLine("No es una letra");
else
{
    char l = char.ToLower(c);
    if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
        Console.WriteLine("Es vocal");
    else
        Console.WriteLine("Es consonante");
}