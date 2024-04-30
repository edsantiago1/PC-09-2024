namespace Semana13{
    class Program{
 class ArregloBidimensional
    {
        /* Programa arreglos_1:

a) solicitar el ingreso de 8 números

b) guardar en un arreglo

c) mostrar los 8 números ingresados

d) mostrar la suma de los 8 números

e) mostrar el promedio de los 8 números */
        private string[,] notas;

        //Metodo cargar
        public void Cargar()
        {
            //Asignando a arreglo un tamaño 5
            notas = new string[4,4];
            string[] opciones = {"Nombre", "Apellido", "Edad", "Telefono"};
            //Declaración de iteración For
                    Console.WriteLine("Ingrese los siguientes datos");
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++){
                    Console.Write($"Ingrese su {opciones[j]}: ");
                    notas[i,j] = Console.ReadLine();
                }
            }
            
        }

        //Metodo para mostrar arreglo
        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine($"Lectura de arreglo en posición: ");
            //Declaración de iteración For
            for(int i = 0; i < notas.GetLength(0); i++)
            {
                for(int j = 0; j < notas.GetLength(1); j++){
                    Console.Clear();
                    Console.WriteLine($"{notas[i,j]}");
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }



        // Metodo principal
        static void Main()
        {
            ArregloBidimensional arregloBidimensional_ = new ArregloBidimensional();
            arregloBidimensional_.Cargar();
            arregloBidimensional_.Imprimir();

        }
    }
    }
}