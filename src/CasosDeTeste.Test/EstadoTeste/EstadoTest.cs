using CasosDeTeste.Console.Estado;
using CasosDeTeste.Console.Identificacao;
using Xunit;

namespace CasosDeTeste.Test.EstadoTeste
{
    public class EstadoTest
    {
        private TipoAmbiente _producao = TipoAmbiente.Producao;
        private TipoAmbiente _homologacao = TipoAmbiente.Homologacao;

        [Fact]
        public void DeveBuscarCorretamenteUrlWebServiceGo()
        {
            var GO = Estado.GO;

            Assert.Equal("https://homolog.sefaz.go.gov.br/nfe/services/v2/CadConsultaCadastro2?wsdl", ObterUrl(GO, _homologacao, ServicoNFe.NfeConsultaCadastro));
            Assert.Equal("https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeAutorizacao?wsdl", ObterUrl(GO, _homologacao, ServicoNFe.NFeAutorizacao));
            Assert.Equal("https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeStatusServico2?wsdl", ObterUrl(GO, _homologacao, ServicoNFe.NfeStatusServico));

            Assert.Equal("https://nfe.sefaz.go.gov.br/nfe/services/v2/CadConsultaCadastro2?wsdl", ObterUrl(GO, _producao, ServicoNFe.NfeConsultaCadastro));
            Assert.Equal("https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeAutorizacao?wsdl", ObterUrl(GO, _producao, ServicoNFe.NFeAutorizacao));
            Assert.Equal("https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeStatusServico2?wsdl", ObterUrl(GO, _producao, ServicoNFe.NfeStatusServico));
        }

        [Fact]
        public void DeveRepresentarOCodigoCorretamente()
        {
            Assert.Equal(12, (int)Estado.AC);
            Assert.Equal(27, (int)Estado.AL);
            Assert.Equal(13, (int)Estado.AM);
            Assert.Equal(16, (int)Estado.AP);
            Assert.Equal(29, (int)Estado.BA);
            Assert.Equal(23, (int)Estado.CE);
            Assert.Equal(53, (int)Estado.DF);
            Assert.Equal(32, (int)Estado.ES);
            Assert.Equal(52, (int)Estado.GO);
            Assert.Equal(21, (int)Estado.MA);
            Assert.Equal(31, (int)Estado.MG);
            Assert.Equal(50, (int)Estado.MS);
            Assert.Equal(51, (int)Estado.MT);
            Assert.Equal(15, (int)Estado.PA);
            Assert.Equal(25, (int)Estado.PB);
            Assert.Equal(26, (int)Estado.PE);
            Assert.Equal(22, (int)Estado.PI);
            Assert.Equal(41, (int)Estado.PR);
            Assert.Equal(33, (int)Estado.RJ);
            Assert.Equal(24, (int)Estado.RN);
            Assert.Equal(11, (int)Estado.RO);
            Assert.Equal(14, (int)Estado.RR);
            Assert.Equal(43, (int)Estado.RS);
            Assert.Equal(42, (int)Estado.SC);
            Assert.Equal(28, (int)Estado.SE);
            Assert.Equal(35, (int)Estado.SP);
            Assert.Equal(17, (int)Estado.TO);

            Assert.Equal("12", EnumUtil.RetornaNameDoAtributo(Estado.AC));
            Assert.Equal("27", EnumUtil.RetornaNameDoAtributo(Estado.AL));
            Assert.Equal("13", EnumUtil.RetornaNameDoAtributo(Estado.AM));
            Assert.Equal("16", EnumUtil.RetornaNameDoAtributo(Estado.AP));
            Assert.Equal("29", EnumUtil.RetornaNameDoAtributo(Estado.BA));
            Assert.Equal("23", EnumUtil.RetornaNameDoAtributo(Estado.CE));
            Assert.Equal("53", EnumUtil.RetornaNameDoAtributo(Estado.DF));
            Assert.Equal("32", EnumUtil.RetornaNameDoAtributo(Estado.ES));
            Assert.Equal("52", EnumUtil.RetornaNameDoAtributo(Estado.GO));
            Assert.Equal("21", EnumUtil.RetornaNameDoAtributo(Estado.MA));
            Assert.Equal("31", EnumUtil.RetornaNameDoAtributo(Estado.MG));
            Assert.Equal("50", EnumUtil.RetornaNameDoAtributo(Estado.MS));
            Assert.Equal("51", EnumUtil.RetornaNameDoAtributo(Estado.MT));
            Assert.Equal("15", EnumUtil.RetornaNameDoAtributo(Estado.PA));
            Assert.Equal("25", EnumUtil.RetornaNameDoAtributo(Estado.PB));
            Assert.Equal("26", EnumUtil.RetornaNameDoAtributo(Estado.PE));
            Assert.Equal("22", EnumUtil.RetornaNameDoAtributo(Estado.PI));
            Assert.Equal("41", EnumUtil.RetornaNameDoAtributo(Estado.PR));
            Assert.Equal("33", EnumUtil.RetornaNameDoAtributo(Estado.RJ));
            Assert.Equal("24", EnumUtil.RetornaNameDoAtributo(Estado.RN));
            Assert.Equal("11", EnumUtil.RetornaNameDoAtributo(Estado.RO));
            Assert.Equal("14", EnumUtil.RetornaNameDoAtributo(Estado.RR));
            Assert.Equal("43", EnumUtil.RetornaNameDoAtributo(Estado.RS));
            Assert.Equal("42", EnumUtil.RetornaNameDoAtributo(Estado.SC));
            Assert.Equal("28", EnumUtil.RetornaNameDoAtributo(Estado.SE));
            Assert.Equal("35", EnumUtil.RetornaNameDoAtributo(Estado.SP));
            Assert.Equal("17", EnumUtil.RetornaNameDoAtributo(Estado.TO));
        } 

        public static string ObterUrl(Console.Estado.Estado estado, TipoAmbiente tpAmbiente, ServicoNFe servico)
        {
            var urlSefaz = new EstadoUrlRepository().GetEstadoUrl(estado, tpAmbiente, servico);

            return urlSefaz.Url;
        }
    }
}