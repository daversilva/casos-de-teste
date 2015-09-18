using System.ComponentModel;
using System.Xml.Serialization;

namespace CasosDeTeste.Console.Identificacao
{
    public enum TipoAmbiente
    {
        [XmlEnum("1")]
        [Description("Produção")]
        Producao = 1,

        [XmlEnum("2")]
        [Description("Homologação")]
        Homologacao = 2
    }

    public enum ServicoNFe
    {
        NfeConsultaCadastro,
        NfeStatusServico,
        NFeAutorizacao,
    }
}