namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string marca, string modelo) : base(numero, marca, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Código para instalar um aplicativo em um Nokia
            Console.WriteLine("Instalando aplicativo {0} no Nokia", nomeApp);
        }
    }
}