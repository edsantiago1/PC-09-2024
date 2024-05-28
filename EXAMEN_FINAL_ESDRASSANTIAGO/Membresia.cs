namespace EXAMENFINAL;

class Membresia{
    string  clientID {get; set;}
    public static List<string> membershipList {get; set;} = new List<string>();


    public Membresia(string clientID){
        this.clientID = clientID;
    }

    public void addMembers(){
        membershipList.Add(clientID);
    }

    public void printMemebers(){
        for(int i = 0; i < membershipList.Count; i++){
            Console.WriteLine($"{i+1}.{membershipList[i]}");
        }
        if(membershipList.Count== 0){
            Console.WriteLine("Aun no existen Clientes registrados");
        }
    }


}
