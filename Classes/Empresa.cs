using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLearn.Classes
{
    public class Empresa
    {
        private IDictionary<int, Trabalhador> dicionarioTrabalhadores = new Dictionary<int, Trabalhador>();

        public List<Trabalho> Trabalhos { get; private set; }

        public string Nome { get; set; }

        public string NomePresidenteEmpresa { get; set; }

        public int TempoTotalDeTrabalho
        {
            get
            {
                //int tempoTotal = 0;
                //Trabalhos.ForEach(x => tempoTotal += x.Tempo);

                //return tempoTotal;

                return Trabalhos.Sum(x => x.Tempo);
            }
        }

        public ISet<Trabalhador> Trabalhadores { get; private set; } = new HashSet<Trabalhador>();

        public Empresa(string nome, string nomePresidenteEmpresa)
        {
            Nome = nome;
            NomePresidenteEmpresa = nomePresidenteEmpresa;
            Trabalhos = new List<Trabalho>();
        }

        internal void RegistrarColaborador(Trabalhador trabalhador)
        {
            Trabalhadores.Add(trabalhador);
            dicionarioTrabalhadores.Add(trabalhador.NumeroIdentificador, trabalhador);
        }

        public void AdicionarTrabalho(Trabalho trabalho)
        {
            Trabalhos.Add(trabalho);
        }

        public override string ToString()
        {
            return $"Empresa: {Nome}\nNome do Presidente:{NomePresidenteEmpresa}\n Tempo Total de trabalho: {TempoTotalDeTrabalho}\nTrabalhos: {string.Join(",", Trabalhos)}";
        }

        internal void SubstituiTrabalhador(Trabalhador trabalhador)
        {
            dicionarioTrabalhadores[trabalhador.NumeroIdentificador] = trabalhador;
        }

        public bool TrabalhadorEstaCadastrado(Trabalhador trabalhador)
        {
            return Trabalhadores.Contains(trabalhador);
        }

        internal Trabalhador BuscaTrabalhadorRegistrado(int numeroRegistro)
        {
            Trabalhador trabalhador = null;
            dicionarioTrabalhadores.TryGetValue(numeroRegistro, out trabalhador);
            return trabalhador;
        }
    }
}
