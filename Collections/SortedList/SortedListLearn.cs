using CollectionsLearn.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.SortedList
{
    public static class SortedListLearn
    {
        //Uma curiosidade é que o SortedList não implementa IList, e sim IDictionary
        //Portanto, SortedList é uma forma de Ordenar Dictionary
        //SortedList organiza as CHAVES de forma ordenada, descrescente

        static IDictionary<string, Trabalhador> trabalhadores 
            = new SortedList<string, Trabalhador>();

        static public void InicializaSortedList()
        {
            adicionarTrabalhadores(trabalhadores);
            imprimirTrabalhadores(trabalhadores);
            
        }

        private static void adicionarTrabalhadores(IDictionary<string, Trabalhador> trabalhadores)
        {
            trabalhadores.Add("CH", new Trabalhador("Carlos Henrique", 3458));
            trabalhadores.Add("AM", new Trabalhador("Amanda Maia", 8965));
            trabalhadores.Add("JH", new Trabalhador("Jorge Henrique", 8877));
            trabalhadores.Add("VM", new Trabalhador("Víctor Marri", 4444));
        }

        private static void imprimirTrabalhadores(IDictionary<string, Trabalhador> trabalhadores)
        {
            foreach (var trabalhador in trabalhadores)
            {
                Console.WriteLine(trabalhador);
            }
        }
    }
}
