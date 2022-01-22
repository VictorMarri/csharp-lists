using CollectionsLearn.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.Dictionary
{
    public static class DictionaryLearn
    {
        static IDictionary<string, Trabalhador> trabalhadores = new Dictionary<string, Trabalhador>();

        //Dictionaries não respeitam uma ordem especifica, ele organiza as chaves de forma não ordenada,
        //portanto, a posição que cada chave ocupa na memoria nçao depende da ordem de inserção.
        //Geralmente, se voce apaga um elemento da lista
        //E logo em seguida insere outro, este outro ficará no lugar do antigo item excluido

        public static void InicializaDictionary()
        {
            adicionarTrabalhadores(trabalhadores);
            imprimirTrabalhadores(trabalhadores);
            testarOrdenaçãoDeDictionary(trabalhadores);
        }

        private static void testarOrdenaçãoDeDictionary(IDictionary<string, Trabalhador> trabalhadores)
        {
            trabalhadores.Remove("AM");
            trabalhadores.Add("CC", new Trabalhador("Caio Costa", 1356));
            Console.WriteLine("Aperte uma tecla para o console limpar...");
            Console.ReadKey(true);
            Console.Clear();
            imprimirTrabalhadores(trabalhadores); //Caio costa vai ficar exatamente no mesmo lugar que Amanda Maia
        }

        private static void imprimirTrabalhadores(IDictionary<string, Trabalhador> trabalhadores)
        {
            foreach (var trabalhador in trabalhadores)
            {
                Console.WriteLine(trabalhador);
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
