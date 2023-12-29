using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando um objeto Nokia
        Nokia nokia = new Nokia("Nokia 8000", "Nokia", "11");

        // Instalando um aplicativo no Nokia
        Console.WriteLine("ligando...");
        nokia.InstalarAplicativo("Instagram");

        // Instanciando um objeto iPhone
        Iphone iphone = new Iphone("iPhone 14 Pro", "Apple", "12");

        // Instalando um aplicativo no iPhone
        Console.WriteLine("ligando...");
        iphone.InstalarAplicativo("Youtube");
    }
}

