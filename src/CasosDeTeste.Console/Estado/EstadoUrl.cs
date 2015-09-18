using CasosDeTeste.Console.Identificacao;

namespace CasosDeTeste.Console.Estado
{
    public struct EstadoUrl
    {
        public Estado CodigoEstado { get; set; }
        public TipoAmbiente TipoAmbiente { get; set; }
        public ServicoNFe TipoServico { get; set; }
        public string Url { get; set; }

        public EstadoUrl(Estado estado, TipoAmbiente tipoAmbiente, ServicoNFe servicoNFe, string url)
            : this()
        {
            this.CodigoEstado = estado;
            this.TipoAmbiente = tipoAmbiente;
            this.TipoServico = servicoNFe;
            this.Url = url;
        } 
    }
}