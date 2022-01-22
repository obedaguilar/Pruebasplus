// See https://aka.ms/new-console-template for more information

Console.WriteLine("Esta es una de las opciones que puedes elegir: \n");
 Console.WriteLine("Inserte los nuevos datos convertir semanas a dias\n" +
            "1.- Ve tus semanas en dias\n" +
            "2.- Pago por horas trabajadas\n"+
            "3.-tienda con impuestos jaja");

int op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:

        Console.WriteLine("Vamos a convertir tus semanas en dias introduce el valor: ");
        int semanas = int.Parse(Console.ReadLine());
        int convDias = semanas * 7;
        Console.WriteLine("convertir a semaas a dias es igual a " + semanas + " convertidos en dias : " + convDias);
        break;
        case 2:
        Console.WriteLine("Ingresa número de horas trabajadas por un empleado: ");
        int Numhoras = int.Parse(Console.ReadLine());
        int totalh = Numhoras * 20;
        Console.WriteLine("el numero de horas trabajadas es igual a :" + Numhoras);
        break;
        case 3:
        Console.WriteLine("bienvenido ala tienda ingresa el precio del producto:");
        decimal producto = decimal.Parse(Console.ReadLine());
        decimal productoConIVA = (producto *  0.18M) / 100;
        decimal resultado = producto + productoConIVA;
        Console.WriteLine("Este es el producto con el IVA: " + resultado);
        break;
    default:
        break;
}