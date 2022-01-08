using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Classes
{
    public class Trabalho : IComparable
    {
        public string TituloTrabalho { get; set; }
        public int Tempo { get; set; }

        public Trabalho(string tituloTrabalho, int tempo)
        {
            TituloTrabalho = tituloTrabalho;
            Tempo = tempo;
        }

        public override string ToString()
        {
            return $"\nTrabalho: {TituloTrabalho}\nTempo: {Tempo}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Trabalho))
            {
                throw new ArgumentException("O Parametro passado não é um Trabalho");
            }

            var trabalhoRecebido = obj as Trabalho;

            return Tempo.CompareTo(trabalhoRecebido.Tempo);
        }
    }
}
