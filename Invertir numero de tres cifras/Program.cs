// See https://aka.ms/new-console-template for more information
int num, aux, dec, uni, cen;
string linea;
Console.WriteLine("Ingresar numero de tres cifras: ");
linea = Console.ReadLine();
num = int.Parse(linea);
cen = num / 100;
num = num % 100;
dec = num / 10;
uni = num % 10;
aux = (uni * 100) + (dec * 10) + cen;
Console.WriteLine("Numero invertido es: " + aux);
Console.WriteLine("pulse una tecla: ");
Console.ReadLine();