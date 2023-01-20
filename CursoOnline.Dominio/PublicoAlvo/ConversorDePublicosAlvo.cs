using CursoOnline.Dominio._Base;
using System;

namespace CursoOnline.Dominio.PublicoAlvo
{
    public class ConversorDePublicosAlvo : IConversorDePublicoAlvo
    {
        public PublicoAlvoEnum Converter(string publicoAlvo)
        {
            ValidadorDeRegra.Novo()
                .Quando(!Enum.TryParse<PublicoAlvoEnum>(publicoAlvo, out var publicoAlvoConvertido), Resources.PublicoAlvoInvalido)
                .DispararExcecaoSeExistir();

            return publicoAlvoConvertido;
        }
    }
}
