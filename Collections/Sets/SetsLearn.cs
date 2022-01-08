using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.Sets
{
    public static class SetsLearn
    {
        /* Ao Professor:
         * 1 - Sets não permitem duplicidade
         * 2 - Os elementos dentro do set não são mantidos em nenhuma ordem especifica
        */

        static ISet<string> alunos = new HashSet<string>();

        public static void IniciaSets()
        {
            VantagensDoHashSet();
            AdicionandoNoSet();
            Imprimir(alunos);
            TestandoPrimeiraRegraDosSets(alunos);
            TestandoSegundaRegraDosSets(alunos);
            OrdenandoSet(alunos);
        }

        private static void OrdenandoSet(ISet<string> alunos)
        {
            //Para ordenarmos um hashset devemos copiar os elementos pra uma lista, que irá fazer a ordenação
            List<string> copia = new List<string>(alunos);
            copia.Sort();
            Console.WriteLine(string.Join(",\n", copia));
        }

        private static void VantagensDoHashSet()
        {
            Console.WriteLine("A vantagem do hashset é a Velocidade. Ele tem uma velocidade 'a longo prazo' MUITO mais efetiva que uma lista por exemplo.");
            Console.WriteLine("Quanto mais elementos voce tem dentro de uma lista, maior vai ser o tempo de busca pra verificarmos se o elemento existe ou não. No caso do hashset esse tempo é praticamente linear");
            Console.WriteLine("Isso ocorre porque numa lista, quando voce procura os elementos, ele percorre do primeiro até o elemento que voce procura, linearmente e de forma crescente");
            Console.WriteLine("No HASHSET, existe um metodo de busca que chama 'tabela' de espalhamento', que ocupa maior memoria, mas te leva mais rapido pro elemento que voce procura");
            Console.WriteLine("Hashset: Escalabilidade, porem  Maior consumo de memoria");
        
        }

        private static void TestandoPrimeiraRegraDosSets(ISet<string> alunos)
        {
            //A Primeira regra dos sets é que 'Sets não permitem duplicidade'
            // Aqui vamos ver que, se eu tentar adicionar um aluno com EXATAMENTE o mesmo nome de um aluno que já está na lista, não vai acontecer absolutamente nada, ou seja, nao teremos duplicidade

            alunos.Add("Victor Marri");
            Imprimir(alunos);
        }

        private static void TestandoSegundaRegraDosSets(ISet<string> alunos)
        {
            //A Segunda regra dos sets é que 'os elementos dentro do set não são manntidos em nenhuma ordem especifica'
            //Aqui vamos ver que, se eu excluir um aluno, e colocar outro logo em seguida nessa lista, o aluno inserido não vai ocupar a ultima posição da lista:
            alunos.Remove("Rafael Merces");
            alunos.Add("Adilson Batista"); //Esse cara vai acabar ocupando o mesmo espaço que o Rafael Merces tinha, comprovando que os elementos não são mantidos numa ordem especifica
            Imprimir(alunos);
        }

        private static void Imprimir(ISet<string> alunos)
        {
            Console.WriteLine(string.Join(",\n", alunos));
        }

        public static void AdicionandoNoSet()
        {
            alunos.Add("Vanessa Mota");
            alunos.Add("Rafael Merces");
            alunos.Add("Victor Marri");
            alunos.Add("Victor Gabriel");
            alunos.Add("John Marston");
        }

        
    }
}
