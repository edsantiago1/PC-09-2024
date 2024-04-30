using System;

public class Program
{
    // propiedades
    int primerNumero;
    string cadena;
    int segundoNumero;


    public static void Main()
    {
        Program programa = new Program(0, "", 0);
        programa.menu();
    }


    Program(int primerNumero, string cadena, int segundoNumero)
    {
        this.primerNumero = primerNumero;
        this.cadena = cadena;
        this.segundoNumero = segundoNumero;
    }

    public void menu()
    {
        int opcion;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido, seleccione una opción:");
            Console.WriteLine("\n 1) Ingreso de valores \n 2) Mostrar valores \n 3) Salir del programa");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out opcion))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entrada no válida, debe ingresar un número entero. Presione una tecla para continuar.");
                Console.ReadKey();
            }
        }

        switch (opcion)
        {
            case 1:
                ingresoValores();
                break;
            case 2:
                Console.WriteLine("Mostrar valores");
                mostrarValores();
                break;
            case 3:
                Console.WriteLine("Salir del programa");
                System.Threading.Thread.Sleep(1000);
                break;
            default:
                Console.WriteLine("Opción no válida. Debe ingresar un número entre 1 y 3. Presione una tecla para continuar.");
                Console.ReadKey();
                menu();
                break;
        }
    }

    public void ingresoValores()
    {
        Console.WriteLine("Menú: Ingreso de valores \n Ingresar primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar cadena:");
        string cadena = Console.ReadLine();

        Console.WriteLine("Ingresar segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        Program objetoProgram = new Program(num1, cadena, num2);
        objetoProgram.menu(); 
    }

    // metodos de la clase
    public void mostrarValores()
    {
        Console.WriteLine($"Menú: Mostrar valores\nPrimer número: {this.primerNumero}");
        Console.WriteLine($"Cadena: {this.cadena}");
        Console.WriteLine($"Segundo número: {this.segundoNumero}\nPresione una tecla para continuar.");
        Console.ReadKey();
        menu();
    }
}