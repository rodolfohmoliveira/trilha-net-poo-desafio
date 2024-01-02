namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - ok Implementado
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        public Iphone(string numero, string modelo, string imei, int memoria) : this(numero)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria1 = memoria;
        }

        public int Memoria1 { get; }

        // TODO: Sobrescrever o método "InstalarAplicativo" - ok Implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo \"" + nomeApp + "\" no Iphone");
        }
    }
}