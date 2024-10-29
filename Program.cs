using System;

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
