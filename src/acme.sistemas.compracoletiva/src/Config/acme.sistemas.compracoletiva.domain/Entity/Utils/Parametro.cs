﻿

namespace acme.sistemas.compracoletiva.domain.Utils
{
    public class Parametro : BaseEntity
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }

        protected Parametro() { }

        public Parametro(string nome, string valor, string descricao) : base()
        {
            Nome = nome;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
