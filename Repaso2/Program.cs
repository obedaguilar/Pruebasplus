// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por favor inserta las categorias que quieras probar\n "+
    "1) para saber si es multiplo de 5 un numero\n "+
    "2) para saber el sueldo de un empleado por horas trabajadas");

int op = 0;
switch (op)
{
    case 1:
        //1.Elaborar un programa que indique si un numero es múltiplo de 5

        Console.WriteLine("Ingresa el numero para saber si es multiplo de 5 en caso de no ser cierto será despedido: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("Este " + numero + " si es un multiplo de 5!!");
        }
        else if (numero % 2 == 1)
        {
            Console.WriteLine("Este numero es pirata , despedido!!!!");
        }
        break;
    case 2:

        Console.WriteLine("hola de nuevo empleado ");
        Console.WriteLine("Por favor ingresa tu numero de horas trabajadas: ");
        int horasTrabajadas = int.Parse(Console.ReadLine());
        int resultado;
        if (horasTrabajadas > 30)
        {
            Console.WriteLine("Excelente su numero de horas trabajadas es mayor que el promedio!! ganara más: ");
            resultado = horasTrabajadas * 20;
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Que mal no le daremos el doble por trabajar menos horas aqui esta su sueldo: ");
            resultado = horasTrabajadas * 10;
            Console.WriteLine(resultado);

        }
        break;
    case 3:
        //        3.Elaborar una calculadora, se ingresara 2 números , en el caso que se ingrese el carácter “+” se sumara . Si se ingresa el “-” se restara, si se
        //ingresar “*” se multiplicara, y si ingresa “/” se dividirá.
        Console.WriteLine("bienvenido a la suma de dos numeros");
        Console.WriteLine("Por favor ingresa el primer numero: ");
        double num = int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor inserta el segundo numero: ");
        double num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el simbolo de la operacion que desea hacer");
        char opcion = char.Parse(Console.ReadLine());
        switch (opcion)
        {
            case '+':
                Console.WriteLine("La suma de los dos numeros es: ");
                double Total = num + num2;
                Console.WriteLine(Total);
                break;
                case '-':
                Console.WriteLine("La resta de los dos numeros es: ");
                double Total1 = num - num2;
                Console.WriteLine(Total1);
                break;
                    case '*':
                Console.WriteLine("La multiplicacion de los dos numeros es: ");
                double Total2 = num * num2;
                Console.WriteLine(Total2);
                break;
                       case '/':
                Console.WriteLine("La division de los dos numeros es: ");
                double Total3 = num / num2;
                Console.WriteLine(Total3);
                break;


            default:
                break;
        }


        break;


    default:
        break;
}


/*2.Un empleado gana al mes de acuerdo a las horas que trabaja ,
 * si trabaja menos de 30 horas gana por hora 10 soles . 
 * En caso que trabaje de 30 horas a mas gana 20 soles por hora*/
