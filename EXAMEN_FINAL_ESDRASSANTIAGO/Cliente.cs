namespace EXAMENFINAL;

class Cliente{
    string id {get;set;} = string.Empty;
    string name {get;set;} = string.Empty;


    public void nuevoCliente(){
        Console.WriteLine("Ingrese Los siguientes datos");
        while(true){
        Console.Write("Nombre: ");
        name = Console.ReadLine() ?? string.Empty;
        if(name == ""){
            Console.WriteLine("Debe ingresar su nombre para continuar");
        }else{
            break;
        }
        }
        while(true){
        Console.Write("ID: ");
        id = Console.ReadLine() ?? string.Empty;
        if(int.TryParse(id, out int idInt)){
            break;
        }else{
            Console.WriteLine("Debe ingresar su ID para continuar(cammpo estricto de valores numericos)");
        }
        }
        Membresia membresia = new Membresia(name);
        membresia.addMembers();
    }

    public bool Menu(){
        Console.Clear();
        Cliente cliente = new Cliente();
        Console.WriteLine("1.Ingresar datos(Nuevo cliente)\n2.Mostrar datos\n3.Salir del programa\n4.Asignar Clases");
        Console.Write("Seleccione la opcion que desea ejecutar, indicando el numero de opcion: ");
        string menu = Console.ReadLine()??string.Empty;
        int.TryParse(menu, out int idInt);
        Console.Clear();
        switch (idInt){
            case 1:
            cliente.nuevoCliente();
            break;
            case 2:
            cliente.mostrarDatos();
            break;
            case 3:
            return false;
            case 4:
            Clase clase = new Clase();
            clase.AsignarClase();
            break;

            default:
            Console.WriteLine("Opcion Invalida");
            break;
        }
        Console.ReadKey();
        return true;
    }

    public void mostrarDatos(){
            Membresia membresia = new Membresia("");
        Console.WriteLine("1.Listado de clientes\n2.Consultar Catalogo de Clases\n3.Listado de sedes.");
        Console.Write("Seleccione que datos desea mostrar, indicando el numero de opcion: ");
        string datos = Console.ReadLine()??string.Empty;
        int.TryParse(datos, out int datosInt);
        switch(datosInt){
            case 1:
            Console.WriteLine("Listado de Cliente:");
            membresia.printMemebers();
            break;
            case 2:
            Clase clase = new Clase();
            clase.ImprimirClase();
            break;
            case 3:
            Console.WriteLine("Sede Principal");
            break;
        }
    }


}
