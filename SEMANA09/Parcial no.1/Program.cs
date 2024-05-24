namespace parcialSemana10
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
            var calculo = new Calculo();
            Console.WriteLine("Ciclo de vida humana");
            Console.Write("Ingrese la edad del usuario: ");
            int edad = int.Parse(Console.ReadLine()??string.Empty);
            float horas = calculo.calculoHoras(edad);
            float dias = calculo.calculoDias(edad);
            float meses = calculo.calculoMeses(edad);
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
            }
            calculo.impresion(horas, dias, meses);
            }
        }
    }
    class Calculo{
        public float calculoHoras(int edad){
            float retorno = 8760 * edad;
            return retorno;
        }
        public float calculoDias(int edad){
            float retorno = 365 * edad;
            return retorno;
        }
        public float calculoMeses(int edad){
            float retorno = 12 * edad;
            return retorno;
        } 
        public void impresion(float horas, float dias, float meses){
            Console.WriteLine($"El usuario ha vivido {horas.ToString("f2")} horas de vida, {dias.ToString("f2")} dias de vida y {meses.ToString("f2")} meses de vida");
        }
    }
}
