using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Classes
{
    public class Trabalhador
    {
        public string Nome { get; set; }
        public int NumeroIdentificador { get; set; }

        public Trabalhador(string nome, int numeroIdentificador)
        {
            Nome = nome;
            NumeroIdentificador = numeroIdentificador;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Numero Identificador: {NumeroIdentificador}";
        }
        
        public override bool Equals(object obj)
        {
            if ((!(obj is Trabalhador)) || obj == null)
            {
                throw new ArgumentException("O Parametro passado não é um Trabalhador válido, ou está nulo");
            }
            
            var objRecebido = obj as Trabalhador;

            return Nome.Equals(objRecebido.Nome);
        }

        /// <summary>
        /// Esse metodo serve para 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}
