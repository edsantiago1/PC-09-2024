using System.Reflection.Metadata;

namespace Parcial{
    class Program{  
        static void Main(){
            Notas notas = new Notas();
            notas.Cargar();
            notas.Imprimir();

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
        

        public void Imprimir(){
            foreach(string datos in datos){
                Console.WriteLine(datos);
            }
        }
}
}
