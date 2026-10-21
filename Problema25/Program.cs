int ica = int.Parse(Console.ReadLine());
string cat;
if (ica < 0)
    cat = "Valor inválido";
else if (ica <= 50)
    cat = "Buena";
else if (ica <= 100)
    cat = "Moderada";
else if (ica <= 150)
    cat = "Dañina para grupos sensibles";
else if (ica <= 200)
    cat = "Dañina";
else
    cat = "Muy dañina";
Console.WriteLine(cat);