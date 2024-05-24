using System.Reflection.Metadata;

namespace Parcial{
    class Program{  
        static void Main(){
            Notas notas = new Notas();
            notas.Cargar();
            while(true){
            notas.Menu();
            }
        }
    }

    class Notas{
        string[,] datos;

        public Notas(){
            datos = new string[2,10];
        }
        public void Cargar(){
            for(int i = 0; i < 2; i++){

                for(int j = 0; j < 10; j++){
                    while(true){
                        string validacionString = "";
                        int validacionInt = 0;
                        if(i == 0){
                            Console.Write($"Ingrese el nombre del estudiante no.{j+1}: "); validacionString = Console.ReadLine()??string.Empty;
                            if(String.IsNullOrEmpty(validacionString)){
                                Console.WriteLine($"Debe ingresar el nombre del alumno no.{j+1} para poder continuar");
                                Console.ReadKey();
                            }else{
                                datos[i,j] = validacionString;
                                break;
                            }
                        }
                        else{    
                            Console.Write($"Ingrese la nota final de {datos[0,j]}: "); validacionString = Console.ReadLine()??String.Empty;
                            if(int.TryParse(validacionString, out validacionInt)){
                                if(validacionInt >= 0 && validacionInt <= 100){
                                    datos[i,j] = validacionInt.ToString();
                                    break;
                                }else{
                                    Console.WriteLine("La nota del alumno no se encuentra en el rango permitido (0-100)");
                                }
                            }else{
                                Console.WriteLine("El valor ingresado es invalido");
                            }
                                
                            }
                            
                        }
                    }
                }
            }
        
        public void Menu(){
            Console.WriteLine("1.Nombre y notas de quienes aprobaron\n2.Nombre y notas de quienes no aprobaron\n3.Nota promedio del salon\nSalir");
            Console.WriteLine("Seleccione la opcion que desea ejecutar indicando el numero de opcion: "); string opcionS = Console.ReadLine()??string.Empty;
            switch(opcionS){
                case "1":
                Aprobados();
                break;
                case "2":
                Reprobados();
                break;
                case "3":
                Promedio();
                break;
                default:
                Console.WriteLine("Opcion invalida");
                break;
            }
        }
        public void Aprobados(){
            Console.WriteLine("Alumnos aprobados:");
            for(int i = 0; i < 10; i++){
                if(int.Parse(datos[1,i]) >= 65 ){
                    Console.WriteLine($"{datos[0,i]}: {datos[1,i]}");
                }
            }
        }
        public void Reprobados(){
            Console.WriteLine("Alumnos reprobados:");
            for(int i = 0; i < 10; i++){
                if(int.Parse(datos[1,i]) < 65 ){
                    Console.WriteLine($"{datos[0,i]}: {datos[1,i]}");
                }
            }
        }
        public void Promedio(){
            int promedio = 0;
            for(int i = 0; i < 10 ; i++){
                promedio += int.Parse(datos[1,i]);
            }
            promedio = promedio / 10;
            Console.WriteLine($"La nota promedio es: {promedio}");
        }
}
}
