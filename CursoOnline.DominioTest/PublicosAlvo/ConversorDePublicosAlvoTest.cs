using CursoOnline.Dominio._Base;
using CursoOnline.Dominio.PublicoAlvo;
using CursoOnline.DominioTest._Util;
using System;
using Xunit;

namespace CursoOnline.DominioTest.PublicosAlvo
{
    public class ConversorDePublicosAlvoTest
    {
        private readonly ConversorDePublicosAlvo _conversorDePublicosAlvo;

        public ConversorDePublicosAlvoTest()
        {
            _conversorDePublicosAlvo = new ConversorDePublicosAlvo();
        }

        [Theory]
        [InlineData(PublicoAlvoEnum.Empregado, "Empregado")]
        [InlineData(PublicoAlvoEnum.Empreendedor, "Empreendedor")]
        [InlineData(PublicoAlvoEnum.Estudante, "Estudante")]
        [InlineData(PublicoAlvoEnum.Universitario, "Universitário")]
        public void DeveConverterPublicoAlvo(PublicoAlvoEnum publicoAlvoEsperado, string publicoAlvoString)
        {
            var publicoAlvoConvertido = _conversorDePublicosAlvo.Converter(publicoAlvoString);

            Assert.Equal(publicoAlvoEsperado, publicoAlvoConvertido);
        }

        [Fact]
        public void NaoDeveConverterQuandoPublicoAlvoEhInvalido()
        {
            const string publicoAlvoInvalido = "Invalido";

            Assert.Throws<ExcecaoDeDominio>(() => _conversorDePublicosAlvo.Converter(publicoAlvoInvalido)).ComMensagem(Resources.PublicoAlvoInvalido);
        }
    }
}
