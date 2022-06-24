using System.Collections.Generic;

namespace acme.sistemas.compracoletiva.domain.Utils
{
    public class Arquivo : BaseEntity
    {
        public string NomeExibicao { get; set; }
        public string NomeSalvo { get; set; }
        public string Caminho { get; set; }
        public string Extensao { get; set; }
        public string Hash { get; set; }

        protected Arquivo() { }

        public Arquivo(string nomeExibicao, string nomeSalvo, string caminho, string extensao, string hash) : base()
        {
            NomeExibicao = nomeExibicao;
            NomeSalvo = nomeSalvo;
            Caminho = caminho;
            Extensao = extensao;
            Hash = hash;
        }
    }
}
