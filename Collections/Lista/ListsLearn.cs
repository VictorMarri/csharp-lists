using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections
{
    public static class ListsLearn
    {
        static List<string> listaPadrao = new List<string>
        {
            "Trabalhando com C#",
            "Trabalhando com Python",
            "Trabalhando com Kotlin",
            "Trabalhando com Ruby"
        };

        public static void Lists()
        {
            ImprimeListaComForeach(listaPadrao);
            ProcurandoUltimaOcorrenciaDeElemento(listaPadrao);
            ProcurandoPrimeiraOcorrenciaDeElemento(listaPadrao);
            InverterLista(listaPadrao);
            RemoverElementoDePosicaoEspecifica(listaPadrao);
            OrdenandoLista(listaPadrao);
            CopiarLista(listaPadrao);
            ClonarLista(listaPadrao);
            RemoveElementos(listaPadrao);
        }

        private static void RemoveElementos(List<string> listaPadrao)
        {
            listaPadrao.RemoveRange(listaPadrao.Count - 2, 2);
            ImprimeLista(listaPadrao);
        }

        private static void ClonarLista(List<string> listaPadrao)
        {
            List<string> clone = new List<string>(listaPadrao);
            ImprimeLista(clone);
        }

        private static void CopiarLista(List<string> listaPadrao)
        {
            //Vou copiar os dois ultimos elementos da minha lista (kotlin, ruby)
            List<string> copia = listaPadrao.GetRange(listaPadrao.Count - 2, 2);
            ImprimeLista(copia);
        }

        private static void OrdenandoLista(List<string> listaPadrao)
        {
            Console.WriteLine("Lista base:");
            ImprimeLista(listaPadrao);
            Console.WriteLine("\n\nLista ordenada:");
            listaPadrao.Sort();
            ImprimeLista(listaPadrao);
        }

        private static void RemoverElementoDePosicaoEspecifica(List<string> listaPadrao)
        {
            Console.WriteLine("Lista base:");
            ImprimeLista(listaPadrao);
            Console.WriteLine("\n\nLista sem elemento:");
            listaPadrao.RemoveAt(listaPadrao.Count - 1);
            ImprimeLista(listaPadrao);
        }

        private static void InverterLista(List<string> listaPadrao)
        {
            Console.WriteLine("Lista base:");
            ImprimeLista(listaPadrao);
            Console.WriteLine("\n\nLista Invertida:");
            listaPadrao.Reverse();
            ImprimeLista(listaPadrao);
        }

        private static void ProcurandoPrimeiraOcorrenciaDeElemento(List<string> listaPadrao)
        {
            Console.WriteLine("A primeira linguagem que estou trabalhando é: " + listaPadrao.First(lista => lista.Contains("Trabalhando")));
        }

        private static void ProcurandoUltimaOcorrenciaDeElemento(List<string> listaPadrao)
        {
            Console.WriteLine("A ultima linguagem que estou trabalhando é: " + listaPadrao.Last(lista => lista.Contains("Trabalhando")));
        }

        private static void ImprimeListaComForeach(List<string> listaPadrao)
        {
            listaPadrao.ForEach(x => Console.WriteLine(x));
        }

        public static void ImprimeLista(List<string> lista)
        {
            Console.WriteLine(string.Join("\n", lista));
        }
    }
}
