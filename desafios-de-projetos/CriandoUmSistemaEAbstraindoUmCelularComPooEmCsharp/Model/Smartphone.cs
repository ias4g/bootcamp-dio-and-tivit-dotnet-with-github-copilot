using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriandoUmSistemaEAbstraindoUmCelularComPooEmCsharp.Model
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
