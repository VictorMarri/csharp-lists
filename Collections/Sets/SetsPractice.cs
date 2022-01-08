using CollectionsLearn.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Collections.Sets
{
    public static class SetsPractice
    {
        public static void Inicializar()
        {
            Empresa empresa = new Empresa("Empresa Pratique", "Victor Marri");

            empresa.AdicionarTrabalho(new Trabalho("Programador Junior", 8));
            empresa.AdicionarTrabalho(new Trabalho("Programador Pleno", 12));
            empresa.AdicionarTrabalho(new Trabalho("Programador Senior", 18));

            Trabalhador trabalhador = new Trabalhador("Josualdo Freitas", 4444);
            Trabalhador trabalhador2 = new Trabalhador("Cristofer Borges", 12520);
            Trabalhador trabalhador3 = new Trabalhador("Carlos Henrique", 147);

            empresa.RegistrarColaborador(trabalhador);
            empresa.RegistrarColaborador(trabalhador2);
            empresa.RegistrarColaborador(trabalhador3);

            Console.WriteLine("Imprimindo os trabalhadores registrados");
            foreach (var colaborador in empresa.Trabalhadores)
            {
                Console.WriteLine(colaborador);
            }

            Console.WriteLine($"\nO colaborador {trabalhador.Nome} está registrado?");
            Console.WriteLine(empresa.TrabalhadorEstaCadastrado(trabalhador));

            //Adicionando um trabalhador
            Trabalhador fabio = new Trabalhador("Fabio Lins", 1478);

            //Substituindo um trabalhador existente
            Trabalhador jorge = new Trabalhador("Jorge Henrique", 4444);
            empresa.SubstituiTrabalhador(jorge);

            //Imprimindo os dados do novo trabalhador, que susbstituiu o anterior com mesmo numero de codigo
            Console.WriteLine("Qual o trabalhador de codigo 4444?: \n");
            Console.WriteLine(empresa.BuscaTrabalhadorRegistrado(4444));
        }
    }
}
