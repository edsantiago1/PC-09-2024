namespace semana_12
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
            Menu();
            }
        }
 
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el primer numero a operar");    int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a operar");    int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la opcion que desea realizar");
            Console.WriteLine("Semana 12");
            Console.WriteLine(" a) Multiplicación");
            Console.WriteLine(" b) suma");
            Console.WriteLine(" c) Resta ");
 
            char? opcion = Console.ReadLine().ToLower()[0];
            switch (opcion)
            {
                case 'a':
                    Console.WriteLine("El resultado es :" + Multiplicacion(valor1, valor2));
                    Console.ReadKey();
 
                    break;
                
                case 'b':
                    Console.WriteLine("El resultado es :" + suma(valor1, valor2));
                    Console.ReadKey();
 
                    break;

                case 'c':
                    Console.WriteLine("El resultado es :" + resta(valor1, valor2));
                    Console.ReadKey();
 
                    break;

                default:
                    Console.WriteLine("La opción seleccionada no es válida.");
                    break;
            }
        }
 
        //envio de parámetros
        public static int Multiplicacion(int a, int b)
        {
            int resultado = 0;
            resultado = a * b;
            return resultado;
        }
                public static int suma(int a, int b)
        {
            int resultado = 0;
            resultado = a + b;
            return resultado;
        }
                public static int resta(int a, int b)
        {
            int resultado = 0;
            resultado = a - b;
            return resultado;
        }
 
    }
}