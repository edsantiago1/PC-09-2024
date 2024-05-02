namespace Semana13{
    class Program{
 class ArregloBidimensional
    {

        private string[,] notas;
        public void Cargar()
        {
            notas = new string[4,4];
            string[] opciones = {"Nombre", "Apellido", "Edad", "Telefono"};
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
                    Console.Clear();
            for(int i = 0; i < notas.GetLength(0); i++)
            {
                for(int j = 0; j < notas.GetLength(1); j++){
                    Console.Write($"{notas[i,j]}");
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        static void Main()
        {
            ArregloBidimensional arregloBidimensional_ = new ArregloBidimensional();
            arregloBidimensional_.Cargar();
            arregloBidimensional_.Imprimir();

        }
    }
    }
}