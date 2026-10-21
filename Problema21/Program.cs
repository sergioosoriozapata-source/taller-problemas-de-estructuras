int cantidad = int.Parse(Console.ReadLine());
string mensaje = "Tienes " + cantidad + " artículo" + ((cantidad == 1) ? "" : "s") + " en el carrito";
Console.WriteLine(mensaje);