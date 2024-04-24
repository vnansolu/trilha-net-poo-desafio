namespace DesafioPOO.Models
{
    // HERDADO E MÉTODOS IMPLEMENTADOS
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalação do Aplicativo {nomeApp} no seu Iphone...");
        }
    }
}