using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
                ordenarMenor();
                break;

                case "4":
                ordenarMayor();
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
        public static void ordenarMenor(){
            Array.Sort(arreglo1);
            foreach(int i in arreglo1){
                Console.WriteLine(i);
            }
        }
        public static void ordenarMayor(){
            Array.Sort(arreglo1);
            Array.Reverse(arreglo1);
            foreach(int i in arreglo1){
                Console.WriteLine(i);
            }            
        }
        public static void editarArreglo(){
            Array.Resize(ref arreglo1, arreglo1.Length+2);
            Console.WriteLine(arreglo1.Length);
            Console.Write("Ingrese el valor para espacio 13 del arreglo: ");
            arreglo1.SetValue(int.Parse(Console.ReadLine()??string.Empty), 12);
            Console.Write("Ingrese el valor para espacio 14 del arreglo: ");
            arreglo1.SetValue(int.Parse(Console.ReadLine()??string.Empty), 13);
            foreach(int i in arreglo1){
                Console.WriteLine(i);
            }
        }
        public static void opSplit(){
            Console.Write("Ingrese una frase de 12 palabras para que el programa la divida: ");
            string palabras = Console.ReadLine()??string.Empty;
            string[] palabras2 = palabras.Split(" ");
            foreach(string palabra in palabras2){
                Console.WriteLine(palabra);
            }
        }
    }
}
