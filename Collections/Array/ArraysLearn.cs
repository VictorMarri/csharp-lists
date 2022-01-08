using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections
{
    public static class ArraysLearn
    {
        static string[] arrayPadrao = new string[]
        {
            "Batatinha quando nasce",
            "Espalha ramas pelo chao",
            "O Brotinho quando ama",
            "Põe a mão no coração"
        };

        public static void Arrays()
        {
            DescobrindoIndice(arrayPadrao);
            TrocarOrdemDosElementos(arrayPadrao);
            RedimensionarArray(arrayPadrao);
            OrdenarArray(arrayPadrao);
            CopiarArray(arrayPadrao);
            ClonarArray(arrayPadrao);
            LimparElementosDoArray(arrayPadrao);
        }

        private static void LimparElementosDoArray(string[] arrayPadrao)
        {
            Console.WriteLine($"Array Original:\n");
            ImprimeArray(arrayPadrao);
            Console.WriteLine("\n\nArray limpo:\n\n");
            Array.Clear(arrayPadrao, 0, 2);
            ImprimeArray(arrayPadrao);
        }

        private static void ClonarArray(string[] arrayPadrao)
        {
            string[] arrayClonado = (string[])arrayPadrao.Clone();

            Console.WriteLine($"Array Clonado:\n");
            ImprimeArray(arrayClonado);
        }

        private static void CopiarArray(string[] arrayPadrao)
        {
            string[] arrayCopia = new string[3];
            Array.Copy(arrayPadrao, 1, arrayCopia, 0, 3);

            Console.WriteLine($"Array Original:\n");
            ImprimeArray(arrayPadrao);
            Console.WriteLine("\n\nArray copiado:\n\n");
            ImprimeArray(arrayCopia);
        }

        private static void OrdenarArray(string[] arrayPadrao)
        {
            Console.WriteLine($"Array Original:\n");
            ImprimeArray(arrayPadrao);
            Console.WriteLine("\n\nArray ordenado:\n\n");
            Array.Sort(arrayPadrao);
            ImprimeArray(arrayPadrao);
        }

        private static void RedimensionarArray(string[] arrayPadrao)
        {
            Console.WriteLine($"Array Original:\n");
            ImprimeArray(arrayPadrao);
            Console.WriteLine("\n\nArray redimensionado:\n\n");
            Array.Resize(ref arrayPadrao, 2);
            ImprimeArray(arrayPadrao);

            #region Explicação do Metodo Resize
            /*O que o compilador basicamente faz nesse metodo é criar um outro array, e passar somente as posições subtraidas para
            esse novo array, entao, no final das contas, estamos imprimindo a copia interna do compilador.*/
            #endregion
        }

        private static void TrocarOrdemDosElementos(string[] arrayPadrao)
        {
            Console.WriteLine($"Array Original:\n");
            ImprimeArray(arrayPadrao);
            Console.WriteLine("\n\nArray invertido:\n\n");
            Array.Reverse(arrayPadrao);
            ImprimeArray(arrayPadrao);
        }

        public static void ImprimeArray(string[] array)
        {
            Console.WriteLine(string.Join("\n", array));
        }

        //public static void ImprimeArrayAlterado(string[] array)
        //{
        //    Console.WriteLine(string.Join("\n", array));
        //}

        private static void DescobrindoIndice(string[] array)
        {
            string elementoProcurado = "O Brotinho quando ama";

            Console.WriteLine($"O Elemento procurado '{elementoProcurado}' está na posição {Array.IndexOf(array, elementoProcurado)} do array");
        }
    }
}
