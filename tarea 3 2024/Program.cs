// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] nombre = { "Daniel", "Carlos", "Maria", "karla" };
int[] salario = { 200, 300, 100, 400 };
int[] horas = { 10, 15, 8, 7 };
int[] salariohoras = { 41, 155, 515, 7 };
int[] cedula = { 1515, 151515, 8488, 84848 };
int[] tipo = { 1, 2, 3, 4 };
int[] porcentaje = { 15, 10, 5, 512 };
int[] salarioaumento = { 15, 51, 45, 96 };
int[] aumento = { 1, 5, 9, 3 };
string salir = "";


for (int i = 0; i < nombre.Length; i++)
{
        Console.Clear();
        Console.WriteLine("Digite la cedula:");
        cedula[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite el nombre:");
        nombre[i] = Console.ReadLine();

        Console.WriteLine("digite el tipo de empleado");
        Console.WriteLine("1-operario");
        Console.WriteLine("2-tecnico");
        Console.WriteLine("3-profecional");
        tipo[i] = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite el salario:");
        salario[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite las horas laboradas:");
        horas[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite el aumento que quiere hacer:");
        porcentaje[i] = int.Parse(Console.ReadLine());
    
}



Console.WriteLine("------Informacon de empleados------");
for (int i = 0; i < nombre.Length; i++)
{
    salariohoras[i] = salario[i] * horas[i];
    aumento[i] = (salariohoras[i] + porcentaje[i]) / 100;
    salarioaumento[i] = aumento[i] + salariohoras[i];

    Console.WriteLine($"Cedula:{cedula[i]}----Nombre:{nombre[i]}----tipo de empleado{tipo[i]}----salario:{salario[i]}----horas trabajadas:{horas[i]}----salario por horas:{salariohoras[i]}----aumento{aumento[i]}----salario con aumento{salarioaumento[i]}");


}


