using System;
public class Santiago
{
int numero;
int numero1;
string cadena;
bool cierreProgram = true;
public static void Main()
{
    Santiago santiago = new Santiago(0,"",0);
    while(santiago.cierreProgram){
        Console.Clear();
        santiago.menu();
    }
}
Santiago(int numero, string cadena, int numero1) {
this.numero = numero;
this.cadena = cadena;
this.numero1 = numero1;
}
void show() {
Console.WriteLine($"Los valores ingresados por el usario son Numero1:{numero}, Numero2:{this.numero1}, String:{this.cadena}");
Console.ReadKey();
}

void nuevo(){
    Console.WriteLine("Ingrese un numero entero: ");
    int params1 = int.Parse(Console.ReadLine()??string.Empty);
    Console.WriteLine("Ingrese una cadena de caracteres: ");
    string? params2 = Console.ReadLine();
    Console.WriteLine("Ingrse otro numero entero: ");
    int params3 = int.Parse(Console.ReadLine()??string.Empty);
    Santiago objetoSantiago = new Santiago(params1, params2, params3);
    objetoSantiago.menu();
}

void menu(){
    Console.WriteLine("1.Ingreso de valores\n2.Mostrar valores\n3.Salir del programa");
    Console.WriteLine("Seleccione una de las 3 opciones, indicando el numero de opcion");
    string? opcion = Console.ReadLine();
    int opcionInt;
    int.TryParse(opcion, out opcionInt);
    switch(opcionInt){
        case 1:
        Console.Clear();
        nuevo();
        break;

        case 2:
        Console.Clear();
        show();
        break;

        case 3:
        Console.Clear();
        cierreProgram = false;
        break;

        default:
        Console.Clear();
        Console.WriteLine("Valor invalido");
        break;
    }
    }
}

