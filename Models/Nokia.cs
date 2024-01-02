namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - ok implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }

        public Nokia(string numero, string modelo, string imei, int memoria) : this(numero)
        {
            Modelo = modelo;
            this.imei = imei;
            Memoria1 = memoria;
        }

        public string imei { get; }
        public int Memoria1 { get; }

        // TODO: Sobrescrever o método "InstalarAplicativo" - ok implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo \"" + nomeApp + "\" no Nokia");
        }
    }
}