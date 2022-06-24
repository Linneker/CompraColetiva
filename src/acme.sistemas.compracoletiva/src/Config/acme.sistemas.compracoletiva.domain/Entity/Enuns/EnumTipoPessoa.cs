using System.ComponentModel;

namespace acme.sistemas.compracoletiva.domain.Entity.Enuns
{
    public enum EnumTipoPessoa
    {
        [Description("Pessoa Física")]
        Fisica = 1,
        [Description("Pessoa Jurídica")]
        Juridica = 2
    }
}
