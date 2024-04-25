using System;
public class Santiago
{
int numero;
int numero1;
string cadena;
public static void Main()
{
    Santiago objetoSantiago = new Santiago();
}
Santiago(int numero, string cadena, int numero1) {
this.numero = numero;
this.cadena = cadena;
this.numero1 = numero1;
}
void show() {
Console.WriteLine(this.numero);
Console.WriteLine(this.cadena);
}

void ingresoParams(){
    Console.WriteLine("Ingrse un numero entero: ");
    int params1 = int.Parse(Console.ReadLine()??string.Empty);
    Console.WriteLine("Ingrese una cadena de caracteres: ");
    string? params2 = Console.ReadLine();
    Console.WriteLine("Ingrse otro numero entero: ");
    int params3 = int.Parse(Console.ReadLine()??string.Empty);
    Santiago objetoSantiago = new Santiago(params1, params2, params3);
}

}

