using CollectionsLearn.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.SortedDictionary
{
    public static class SortedDictionaryLearn
    {
        //A Diferença entre o SortedList e o SortedDictionary é que a sorted list trabalha com duas listas internas, uma lista de chaves e uma lista de valores
        //Conforme adicionamos itens no dicionario, as chaves vão sendo automaticamente organizadas
        //Na SortedDictionary é mais eficiente a inserção e remoção de elementos com certa frequencia, pois a forma que o SortedDictionary trabalha organizando os valores é em forma de um grafo
        //Isso torna a organização mais simples


        static IDictionary<string, Trabalhador> trabalhadores
            = new SortedDictionary<string, Trabalhador>();

        static public void InicializaSortedDictionary()
        {
            adicionarTrabalhadores(trabalhadores);
            imprimirTrabalhadores(trabalhadores);

        }

        private static void imprimirTrabalhadores(IDictionary<string, Trabalhador> trabalhadores)
        {
            foreach (var item in trabalhadores)
            {
                Console.WriteLine(item);
            }
        }

        private static void adicionarTrabalhadores(IDictionary<string, Trabalhador> trabalhadores)
        {
            trabalhadores.Add("CH", new Trabalhador("Carlos Henrique", 3458));
            trabalhadores.Add("AM", new Trabalhador("Amanda Maia", 8965));
            trabalhadores.Add("JH", new Trabalhador("Jorge Henrique", 8877));
            trabalhadores.Add("VM", new Trabalhador("Víctor Marri", 4444));
        }
    }
}
