string j1 = Console.ReadLine();
string j2 = Console.ReadLine();
if (j1 == j2)
    Console.WriteLine("Empate");
else if (j1 == "piedra" && j2 == "tijera")
    Console.WriteLine("Gana el jugador 1");
else if (j1 == "tijera" && j2 == "papel")
    Console.WriteLine("Gana el jugador 1");
else if (j1 == "papel" && j2 == "piedra")
    Console.WriteLine("Gana el jugador 1");
else
    Console.WriteLine("Gana el jugador 2");