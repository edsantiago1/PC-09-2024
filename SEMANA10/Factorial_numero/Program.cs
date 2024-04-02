using System.Security.Cryptography.X509Certificates;

namespace factorilNumero{
    class Program{
        public static void Main(string[] args){
            while(true){
            Console.Write("Ingrese un numero para conocer el valor de su factorial: ");
            int numero = int.Parse(Console.ReadLine());
            int Factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es {CalcularFactorial(numero)}");
            }
        }

        public static int  CalcularFactorial(int numero){
            if (numero == 0 ){
                return 1;
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
