namespace SEMANA7PRACTICA
{
    class SEMANA7ESDRAS
    {
        static void Main(string[] args)
        {
            string value1 = " a";
            string value2 = "Esdras ";
            string texto;
            string palabra = "";

            /* Trim quita el espacio en blanco
               ToLower convierte de mayuscula a minuscula el texto */
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
            Console.WriteLine("Hola, ingrese texto");
            texto = Console.ReadLine();
            Console.WriteLine("ingrese palabra a comparar");
            palabra = Console.ReadLine();

            Console.WriteLine("Contains: " + texto.Contains("Esdras"));
            Console.WriteLine("Starts With: " + texto.StartsWith("Esdras"));
            Console.WriteLine("Ends Whit: " + texto.EndsWith("Esdras"));
            Console.ReadKey();
        }
    }
}