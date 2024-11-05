﻿using System;

bool isOld=true;
string myName="Ana Galvez";
char aLetter='a';
double number2= 22.232;
string[] names={"ana","tatin","john","henry"};

Console.WriteLine(names[0]);
names[1]="otroTatin";
Console.WriteLine(names[1]);

string[] cars=new string[3] {"Ford","Fiat","Renault"};

foreach (string car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine("Ingresa el primer número"); // WriteLine siempre devuelve un string
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El número ingresado es: "+ number1);
Console.WriteLine($"El número {number1} + 3 es: {number1 + 3}"); // traspolación
Console.WriteLine("---------------");
Console.WriteLine("Hello World!");

if (number1 >= 18)
{
    Console.WriteLine("This person is old");
}else
{
    Console.WriteLine("This person isn't old");
}
// FizzBuzz
for (int i = 1; i < 100;i++)
{
    if (i%3==0 && i%5==0)
    {
        Console.WriteLine("fizz-buzz");
    }
    else if (i%3==0)
    {
        Console.WriteLine("fizz");
    }
    else if (i%5==0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
// Crea una única función (importante que sólo sea una) que sea capaz de calcular y retornar el área de un polígono.
//  La función recibirá por parámetro sólo UN polígono a la vez.Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
//  Imprime el cálculo del área de un polígono de cada tipo.
// area de un triángulo: (base * altura) / 2
// area de un cuadrado: lado * lado
// polígono de un rectángulo: largo * ancho

static double AreaPoligono(string tipoPoligono)
{
    double result;
    switch (tipoPoligono)
    {
        case "Triangulo":
            Console.WriteLine("Escriba la base");
            double baset= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la altura");
            double alturat= Convert.ToDouble(Console.ReadLine());
            return result=(baset*alturat)/2;
        case "Cuadrado":
            Console.WriteLine("Escriba el lado del cuadrado");
            double ladoC= Convert.ToDouble(Console.ReadLine());
            return result=ladoC*ladoC;
        case "Rectangulo":
            Console.WriteLine("Escriba el largo del rectángulo");
            double largoR= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el ancho del rectángulo");
            double anchoR= Convert.ToDouble(Console.ReadLine());  
            return result=largoR*anchoR;
        default:
            Console.WriteLine("Polígono incorrecto");
            break;
    }
    return result=1;
}

Console.WriteLine("Ingrese que polígono desea saber su área: Triángulo,Cuadrado,Rectángulo");
string poligono=Console.ReadLine();
Console.WriteLine(AreaPoligono(poligono));

//  Crea un programa que invierta el orden de una cadena de texto
//  sin usar funciones propias del lenguaje que lo hagan de forma automática.
//  Si le pasamos "Hola mundo" nos retornaría "odnum aloH"

static string invertirCadena(string cadena)
{
    int longitud=cadena.Length;
    string reverso="";
    foreach (char letra in cadena)
    {
        reverso= letra + reverso;
    }
    return reverso;
}
string cadena="hola como estas";
Console.WriteLine(invertirCadena(cadena));

//Crea un programa se encargue de transformar un número
//decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.

static string decABinario(int numero)
{
    string binario="";
    while (numero > 0)
    {
        binario=$"{numero%2}{binario}";
        numero = numero / 2;

    }
    return binario;
}
Console.WriteLine(decABinario(8183));



static string invertirCadena1(string cadena1)
{
    string cadenaInv="";
    for(int i=cadena1.Length-1;i>=0;i--)
    {
        cadenaInv+=cadena1[i];
    }

    return cadenaInv;
}
string cadena1="hola como estas";
Console.WriteLine(invertirCadena1(cadena1));

// Crea una función que reciba dos cadenas como parámetro (str1, str2)
// e imprima otras dos cadenas como salida (out1, out2).
// out1 contendrá todos los caracteres presentes en la str1 pero NO
// estén presentes en str2.
// out2 contendrá todos los caracteres presentes en la str2 pero NO
// estén presentes en str1.

static void caracteresDiferentes(string str1,string str2)
{
  string out1="";
  string out2="";
  foreach (var letra1 in str1)
  {
    if(!str2.Contains(letra1))
    {
      out1+=letra1;
    }
  }
  foreach (var letra2 in str2)
  {
    if(!str1.Contains(letra2))
    {
      out2+=letra2;
    }
  }
  Console.WriteLine($"Lo que tiene la primera cadena pero no la segunda: {out1}");
  Console.WriteLine($"Lo que tiene la segunda cadena pero no la primera: {out2}");
}
string str1="hola ana como eta";
string str2="holis anita que tal";

caracteresDiferentes(str1,str2);

static void division(int dividendo,int divisor)
{
    double cociente=dividendo/divisor;
    int resto=dividendo%divisor;
    Console.WriteLine($"El cociente es: {cociente}");
    Console.WriteLine($"El resto es: {resto}");
}

division(83,16);