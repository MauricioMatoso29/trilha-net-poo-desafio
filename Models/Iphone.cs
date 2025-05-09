using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // Este construtor chama implicitamente o construtor da classe base
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }

        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}