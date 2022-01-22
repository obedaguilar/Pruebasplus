// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Se tiene el siguiente array de números . Calcular cuantos elementos son pares
//y cuantos son impares

int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };
//int nelementos = valores.Length;
//forma trabajosa como dice mi cuate 
//for (int i = 0; i < nelementos; i++)
//{
//    Console.WriteLine(valores[i]);

//}

foreach (int val in valores) { 
    Console.WriteLine(val);
}


//Console.WriteLine("valores" + valores.Length);
//Console.WriteLine("valores" + valores[0]);
//Console.WriteLine("el ultimo elemento" + valores[valores.Length -1]);

//int[] notas = new int[4]; //otra forma de definir los arrays

//notas[0] = 1;
//notas[1] = 2;
//notas[2] = 3;
//notas[3] = 4;

//para poners un array de array

string[,] nombrescompletos = {

{"Julio", "Nieves", "Sandoval" },
{"Norberto","Pedraza","Murayari" },
{"Pablo", "Picaso", "Pedraza" }

};

Console.WriteLine(nombrescompletos[1, 1]);



