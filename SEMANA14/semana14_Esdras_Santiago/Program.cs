using System.Collections;
using System.Runtime.CompilerServices;

namespace Semana14{
    class Mainclass{
        private static int[] arreglo1 = new int[12];
        private static string? opcion;
        private static string[] opciones = {"Mostrar la suma de los números del arreglo","Mostrar el promedio de los números","Ordenar de menor a mayor y mostrar","Ordenar de mayor a menor y mostrar","Cambiar tamaño de arreglo, añadir dos posiciones mas con su respectivo valor y mostrar","Utilizar el operador split()"};
        public static void Main(string[]args){
            solicitarDatos();
            menuOpciones();
        }
        public static void solicitarDatos(){
            for(int i = 0; i < arreglo1.Length; i++){
                Console.WriteLine($"Ingrese el numero para el espacio {i+1}: ");
                arreglo1[i] = int.Parse(Console.ReadLine()??string.Empty);
            }
        }
        public static void menuOpciones(){
            int i = 0;
            foreach(string opcion in opciones){
                i++;
                Console.WriteLine(i+"."+opcion);
            }
            Console.Write("Seleccione la opcion que desea ejecutar, indicando el numero de opcion: ");
            opcion = Console.ReadLine()??string.Empty;
            switch(opcion){
                case "":
                Console.WriteLine("Debe ingresar un valor");
                break;

                case "1":
                sumaArreglo();
                break;

                case "2":
                promedioArreglo();
                break;

                case "3":
                ordenarMayor();
                break;

                case "4":
                ordenarMenor();
                break;

                case "5":
                editarArreglo();
                break;

                case "6":
                opSplit();
                break;
            }
        }
        public static void sumaArreglo(){
            int suma = 0;
            for(int i = 0; i < arreglo1.Length; i++){
                suma += arreglo1[i];
            }
            Console.WriteLine(suma);
        }
        public static void promedioArreglo(){
            int suma = 0;
            for (int i = 0; i < arreglo1.Length; i++){
                suma += arreglo1[i];
            }
            Console.WriteLine(suma/arreglo1.Length);
        }
        public static void ordenarMayor(){
            int mayor = 0;
            for (int i = 0; i < arreglo1.Length; i++){
                
            }
        }
        public static void ordenarMenor(){

        }
        public static void editarArreglo(){
            
        }
        public static void opSplit(){

        }
    }
}
