using System.Collections.Generic;
using System.Linq;
using CasosDeTeste.Console.Identificacao;

namespace CasosDeTeste.Console.Estado
{
    public class EstadoUrlRepository
    {
        public static readonly List<EstadoUrl> Urls = new List<EstadoUrl>
        {
            new EstadoUrl(Estado.GO, TipoAmbiente.Producao, ServicoNFe.NFeAutorizacao, @"https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeAutorizacao?wsdl"),
            new EstadoUrl(Estado.GO, TipoAmbiente.Producao, ServicoNFe.NfeStatusServico, @"https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeStatusServico2?wsdl"),
            new EstadoUrl(Estado.GO, TipoAmbiente.Producao, ServicoNFe.NfeConsultaCadastro, @"https://nfe.sefaz.go.gov.br/nfe/services/v2/CadConsultaCadastro2?wsdl"),
            new EstadoUrl(Estado.GO, TipoAmbiente.Homologacao, ServicoNFe.NFeAutorizacao, @"https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeAutorizacao?wsdl"),
            new EstadoUrl(Estado.GO, TipoAmbiente.Homologacao, ServicoNFe.NfeStatusServico, @"https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeStatusServico2?wsdl"),
            new EstadoUrl(Estado.GO, TipoAmbiente.Homologacao, ServicoNFe.NfeConsultaCadastro, @"https://homolog.sefaz.go.gov.br/nfe/services/v2/CadConsultaCadastro2?wsdl"),

        };

        public EstadoUrl GetEstadoUrl(Estado estado, TipoAmbiente tpAmbiente, ServicoNFe servicoNFe)
        {
            var url =
                Urls.FirstOrDefault(
                    c => c.CodigoEstado == estado && c.TipoAmbiente == tpAmbiente && c.TipoServico == servicoNFe);

            return url;
        } 
    }
}