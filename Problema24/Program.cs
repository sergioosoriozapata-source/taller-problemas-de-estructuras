int dia = int.Parse(Console.ReadLine());
string tipo;
if (dia < 1 || dia > 7)
    tipo = "Día inválido";
else if (dia <= 5)
    tipo = "Día hábil";
else
    tipo = "Fin de semana";
Console.WriteLine(tipo);