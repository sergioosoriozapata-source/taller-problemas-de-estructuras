int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());
int resultado = 0;
switch (op)
{
    case '+':
        resultado = a + b;
        break;
    case '-':
        resultado = a - b;
        break;
    case '*':
        resultado = a * b;
        break;
    case '/':
        if (b == 0)
            throw new Exception("No se puede dividir entre cero");
        resultado = a / b;
        break;
    default:
        throw new Exception("Operador no soportado");
}
Console.WriteLine(a + " " + op + " " + b + " = " + resultado);