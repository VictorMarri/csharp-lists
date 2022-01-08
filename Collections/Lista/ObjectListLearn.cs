using CollectionsLearn.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.Lista
{
    public static class ObjectListLearn
    {
        static Trabalho trabalhoCSharp = new Trabalho("Trabalho com C#", 20);
        static Trabalho trabalhoKotlin = new Trabalho("Trabalho com Kotlin", 70);
        static Trabalho trabalhoJava = new Trabalho("Trabalho com Java", 10);

        static List<Trabalho> trabalhos = new List<Trabalho>
        {
            trabalhoCSharp,
            trabalhoKotlin,
            trabalhoJava,
        };

        public static void ListaObjetos()
        {
            //ImprimirLista(trabalhos);
            //OrdenarListaPorComparable(trabalhos);
            //OrdenarListaPorSort(trabalhos);
        }

        private static void OrdenarListaPorSort(List<Trabalho> trabalhos)
        {
            trabalhos.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            ImprimirLista(trabalhos);
        }

        private static void OrdenarListaPorComparable(List<Trabalho> trabalhos)
        {
            Console.WriteLine("Lista Ordenada:\n");
            trabalhos.Sort();
            ImprimirLista(trabalhos);
        }

        private static void ImprimirLista(List<Trabalho> trabalhos)
        {
            trabalhos.ForEach(x => Console.WriteLine(x));
        }
    }
}
