namespace EXAMENFINAL;

class Clase{

    public static List<string> Clases { get; set; } = new List<string>();
    public void AsignarClase(){
        Membresia membresia = new Membresia("");
        if(Membresia.membershipList.Count > 0){
        membresia.printMemebers();
        Console.Write("Seleccione el cliente al cual desea asignar una clase, indicando el numero de cliente: ");
        string client = Console.ReadLine() ?? string.Empty;
        int.TryParse(client, out int num);
        Console.WriteLine("Indique la fecha en la cual va a asignar la clase");
        string fecha = Console.ReadLine() ?? string.Empty;
        Clases.Add("Nombre: "+Membresia.membershipList[num-1] +"\t"+"Fecha: "+ fecha);
        }else{
            Console.WriteLine("Aun no existen clientes registrados a los que asignar una clase.");
        }
    }

    public void ImprimirClase(){
        foreach(string  clase in Clases){
            Console.WriteLine(clase);
        }
        if(Clases.Count == 0){
            Console.WriteLine("Aun no hay clases asignadas");
        }
    }
}
