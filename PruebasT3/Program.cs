// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int op = 0;
switch (op)
{
    case 1:
        Console.WriteLine("Hasta acá termina la serie");
        int numero = 19;
        int c = 21;

        while (numero < 37) //sirve para repetir la condición hasta que llegue al valor o caracter
        {

            numero += 2;
            Console.WriteLine("Los numeros son " + numero);

        }
        //Se les considera contador a las variables son iguales a 0, para aumento, ejemplo contador++,contador+=, contador!=
        c += 10;
        Console.WriteLine("Valor c " + c); //CTRL+K,D para ordenar código
        break;
    case 2:
        Console.WriteLine("segundo ejercicio ciclo do while");
        double division, num;

        do
        {
            Console.WriteLine("si esto es un producto para comenzar ");
            string cadena;
            cadena = Console.ReadLine();
            num = double.Parse(cadena);
            division = num / 2;
            Console.WriteLine("Aca este numero que es " + division);

        } while (num >0);
        break;




    default:
        break;
}