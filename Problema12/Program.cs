bool tieneEmpleo = true;
double ingreso = 3000000;
if (tieneEmpleo == false)
    Console.WriteLine("Crédito rechazado");
else if (ingreso >= 2500000)
    Console.WriteLine("Crédito alto aprobado");
else
    Console.WriteLine("Crédito básico aprobado");