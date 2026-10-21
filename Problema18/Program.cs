double estatura = 1.50;
int edad = 13;
bool acompanado = false;
bool puedeSubir = estatura >= 1.40 && (edad >= 12 || acompanado);
if (puedeSubir)
    Console.WriteLine("Puede subir");
else
    Console.WriteLine("No puede subir");