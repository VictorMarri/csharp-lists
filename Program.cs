using System;
using CollectionsLearn.Collections;
using CollectionsLearn.Collections.LinkedList;
using CollectionsLearn.Collections.Lista;
using CollectionsLearn.Collections.Sets;

namespace CollectionsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha sobre qual estrutura de dados você quer operar:");
            Console.WriteLine("1 - Array\n2 - Lists\n3 - ObjectList\n4 - Sets\n5 - LinkedList");
            int escolhaEstrutura = int.Parse(Console.ReadLine());

            switch (escolhaEstrutura)
            {
                case 1:
                    Console.Clear();
                    ArraysLearn.Arrays();
                break;

                case 2:
                    Console.Clear();
                    ListsLearn.Lists();
                break;

                case 3:
                    Console.Clear();
                    ObjectListLearn.ListaObjetos();
                break;

                case 4:
                    Console.Clear();
                    SetsLearn.IniciaSets();
                break;

                case 5:
                    Console.Clear();
                    LinkedListLearning.Inicializar();
                break;
            }

            Console.ReadKey(true);
        }

    }
}
