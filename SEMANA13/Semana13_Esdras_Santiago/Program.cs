namespace Semana13{
    class Program{
 class ArregloUnidimensional
    {
        /* Programa arreglos_1:

a) solicitar el ingreso de 8 números

b) guardar en un arreglo

c) mostrar los 8 números ingresados

d) mostrar la suma de los 8 números

e) mostrar el promedio de los 8 números */
        private int[] notas;

        //Metodo cargar
        public void Cargar()
        {
            //Asignando a arreglo un tamaño 5
            notas = new int[8];

            //Declaración de iteración For
            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Ingrese valor para posición {i+1}: ");
                notas[i] = int.Parse(Console.ReadLine()??string.Empty);
            }
        }

        //Metodo para mostrar arreglo
        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine($"Lectura de arreglo en posición: ");
            //Declaración de iteración For
            for(int im= 0; im < notas.Length; im++){
                Console.WriteLine($"{im}: {notas[im]}");
            }
            Console.ReadKey();
        }

        public void sumaNumeros(){
            int resultadoSuma = 0;
            Console.WriteLine("");
            Console.WriteLine($"Resultado de suma {notas.Length} numeros: ");

            foreach(int n in notas){
                resultadoSuma += n;
            }
            Console.Write(resultadoSuma);
        }

        public void promedioNumeros(){
            int resultadoPromedio = 0;
            Console.WriteLine("");
            Console.WriteLine($"Resultado promedio {notas.Length} numeros: ");

            foreach(int p in notas){
                resultadoPromedio += p;
            }
            Console.Write(resultadoPromedio/notas.Length);
        }

        // Metodo principal
        static void Main()
        {
            ArregloUnidimensional arregloUnidimensional_ = new ArregloUnidimensional();
            arregloUnidimensional_.Cargar();
            arregloUnidimensional_.Imprimir();
            arregloUnidimensional_.sumaNumeros();
            arregloUnidimensional_.promedioNumeros();
        }
    }
    }
}