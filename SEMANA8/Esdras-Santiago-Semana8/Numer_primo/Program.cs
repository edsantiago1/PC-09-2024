namespace Program
{
    class Numero_primo
    {
        static void Main(string[] args)
        {
            string titulo = "Calculador de numeros primos";
            Console.SetCursorPosition((Console.WindowWidth - titulo.Length) / 2, Console.CursorTop);
            Console.WriteLine(titulo);
            while (true){
                int decision = 0;
                Console.Write("Ingrese el número que desea comprobar si es número primo: "); int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++){
                    if (num % i == 0){
                        decision++;
                    }
                    if (decision > 2){
                        Console.WriteLine($"El numero :{num} no es un numero primo");
                        break;
                    }
                }
                if (decision == 2){
                    Console.WriteLine($"El numero :{num} es un numero primo");
                }else if (decision < 2){
                        Console.WriteLine($"El numero :{num} no es un numero primo");
                    }
            }
        }
    }
}
