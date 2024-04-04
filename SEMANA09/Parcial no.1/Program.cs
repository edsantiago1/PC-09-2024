namespace Program
{
    class Numero_primo
    {
        static void Main(string[] args)
        {
            while(true){
            Console.WriteLine("Ciclo de vida humana");
            Console.Write("Ingrese la edad del usuario: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad>=0&&edad<=5){
                Console.WriteLine("El usuario se encuentra en la primera infancia");
            }
            else if (edad>=6&&edad<=11){
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
            }}
        }
    }
}
