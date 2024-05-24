namespace numeroPrimo
{
    class Progam
    {
        static void Main(string[] args)
        {
            while(true){
            Console.Clear();
            Console.WriteLine("Ciclo de vida humana");
            Console.Write("Ingrese la edad del usuario: ");
            int edad = int.Parse(Console.ReadLine()??string.Empty);
            if (edad>=0&&edad<=5){
                Console.WriteLine("El usuario se encuentra en la primera infancia");
            }
            else if (edad>=6&&edad<=1){
                Console.WriteLine("El usuario se encuentra en la infancia");
            }
            else if (edad>=12&&edad<=18){
                Console.WriteLine("El usuario se encuentra en la adolescencia");
            }
            else if (edad>=19&&edad<=25){
                Console.WriteLine("El usuario se encuentra en la juventud");
            }
            else if (edad>=26&&edad<=59){
                Console.WriteLine("El usuario se encuentra en la adultez");
            }
            else if (edad>=60){
                Console.WriteLine("El usuario es una persona mayor");
            }
            Console.ReadKey();
            }
        }
    }
}
