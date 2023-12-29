namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string marca, string modelo) : base(numero, marca, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Código para instalar um aplicativo em um iPhone
            Console.WriteLine("Instalando aplicativo {0} no iPhone", nomeApp);
        }
    }
}