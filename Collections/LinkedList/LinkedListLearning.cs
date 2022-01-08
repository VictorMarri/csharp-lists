using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.LinkedList
{
    public static class LinkedListLearning
    {
        //Quando a gente tem uma lista, os dados ficam armazenados aproximadamente assim:
        //Memoria -> [segunda][terca][quarta][quinta][][]
        //Dessa forma, adicionar um elemento ao final de uma lista é fácil, ele vai automaticamente
        //Porém, pra gente inserir um item no meio dessa lista exige mais esforço computacional, pq n pode ficar um buraco no array
        //Se removermos esse elemento do meio, os outros elementos terão que se deslocaods para a lista ficar enxuta
        //Esse processo, quanto maior a lista, mais ineficiente é 
        //E uma coleção apropriada pra inserção e remoção rápida é as listas linkadas. LinkedLists
        //Nelas os elementos não precisam estar em sequencia na memoria
        //Cada elemento é um nó, que representa um valor. 
        //Cada valor tem um PONTEIRO, que aponta para o elemento da frente

        public static void Inicializar()
        {
            LinkedList<string> dias = new LinkedList<string>();

            ExecutarLinkedList(dias);
        }

        private static void ExecutarLinkedList(LinkedList<string> dias)
        {
            var lista = AdicionarItensNaLinkedList(dias);

            ImprimirLinkedList(lista);

            Console.WriteLine(AcharUmItemNaLinkedList(lista));

            RemoverUmElemento(lista);
        }

        private static void RemoverUmElemento(LinkedList<string> lista)
        {
            lista.Remove("Quarta");

            Console.WriteLine("\n\n\n");

            ImprimirLinkedList(lista);
        }

        private static bool AcharUmItemNaLinkedList(LinkedList<string> lista)
        {
            //LinkedList NÃO DÁ suporte ao acesso dos elementos por índice. EX: dias[0]
            //Por isso a gente faz um laço foreach, e não um FOR!

            var quarta = lista.Find("Quarta");

            return quarta.Value != null ? true : false;
        }

        private static LinkedList<string> AdicionarItensNaLinkedList(LinkedList<string> dias)
        {
            var d4 = dias.AddFirst("Quarta"); //Quarta é o primeiro elemento da lista ligada

            //Cada elemento dessa lista NÃO É UMA STRING, E SIM UM NÓ. Isso quer dizer que não é um tipo de valor, não conseguimos pegar o valor somente referenciando a posição.

            //Para pegarmos o valor, pegamos a propriedade.value:
            Console.WriteLine($"d4.Value: {d4.Value}");

            //LinkedLista não possuem Add, se voce reparar
            //Isso porque não existe uma ordem pré feita de como serão adicionados os itens
            //Podemos adicionar de 4 formas:
            // 1 - Com primeiro nó (AddFirst)
            // 2 - Como ultimo nó (AddLast)
            // 3 - Antes de um nó conhecido
            // 4 - Depois de um nó conhecido

            //Vou adicionar segunda antes de quarta: 
            var d2 = dias.AddBefore(d4, "Segunda");
            //Agora, d2 e d4 estão ligados (d2) <-> (d4)
            //Com isso d2.Next é igual a d4!
            //Com isso d4.Previous é igual a d2!

            //Vou adicionar terça depois de segunda
            var d3 = dias.AddAfter(d2, "Terça");
            //Agora está assim (d2)<->(d3)<->(d4)

            //Adicionando sexta depois da quarta
            var d6 = dias.AddAfter(d4, "Sexta");
            //Agora está assim (d2)<->(d3)<->(d4)<->(d6) 

            //Adicionando sabado depois da sexta
            var d7 = dias.AddAfter(d6, "Sabado");
            //Agora está assim (d2)<->(d3)<->(d4)<->(d6)<->(d7)

            //Adicionando Quinta antes da sexta
            var d5 = dias.AddBefore(d6, "Quinta");
            //Agora está assim (d2)<->(d3)<->(d4)<->(d5)<->(d6)<->(d7)

            return dias;
        }

        private static void ImprimirLinkedList(LinkedList<string> dias)
        {
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}
