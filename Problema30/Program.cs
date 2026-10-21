double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());
double prom = (n1 + n2 + n3) / 3.0;
char letra;
if (prom >= 90)
    letra = 'A';
else if (prom >= 80)
    letra = 'B';
else if (prom >= 70)
    letra = 'C';
else if (prom >= 60)
    letra = 'D';
else
    letra = 'F';
string feedback;
if (letra == 'A')
    feedback = "Desempeño excelente";
else if (letra == 'B' || letra == 'C')
    feedback = "Buen desempeño, sigue así";
else if (letra == 'D')
    feedback = "Aprobado, refuerza los temas";
else
    feedback = "Debe presentar plan de mejoramiento";
string estado = (prom >= 60) ? "Aprobado" : "Reprobado";
Console.WriteLine("Promedio: " + prom.ToString("F1") + " | Letra: " + letra + " | " + feedback + " | " + estado);
if (prom == 100)
    Console.WriteLine("¡Mención de honor!");