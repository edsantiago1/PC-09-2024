using System.Formats.Asn1;

namespace factorialNumero{
    class Program{
        public static void Main(string[] args){
            while(true){
            Console.Write("Ingrese un numero para conocer el valor de su factorial: ");
            int numero = int.Parse(Console.ReadLine()??string.Empty);
            int Factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es {Factorial}");
            }
        }

        public static int  CalcularFactorial(int numero){
            if (numero == 0 ){
                return 1;
            }else if(numero < 0 ){
                Console.WriteLine("El numero ingresado no es un entero positivo");
                return 0;
            }else{
                int factorial = 1;
                for(int i = 1; i <= numero; i++){
                    factorial *= i;
                }
                
                    return factorial;
            }

        }
    }
}
