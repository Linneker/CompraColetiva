using System.ComponentModel;

namespace acme.sistemas.compracoletiva.domain.Enuns
{
    public enum EnumTipoPessoa
    {
        [Description("Pessoa Física")]
        Fisica = 1,
        [Description("Pessoa Jurídica")]
        Juridica = 2
    }
}
