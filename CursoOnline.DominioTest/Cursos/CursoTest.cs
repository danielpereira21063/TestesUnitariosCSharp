using Bogus;
using CursoOnline.Dominio;
using CursoOnline.DominioTest._Util;
using CursoOnline.DominioTest.Builders;
using ExpectedObjects;
using System;
using Xunit;
using Xunit.Abstractions;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest : IDisposable
    {
        private readonly ITestOutputHelper _output;

        private readonly string _nome;
        private readonly double _cargaHoraria;
        private readonly PublicoAlvo _publicoAlvo;
        private readonly double _valor;
        private readonly string _descricao;

        public CursoTest(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Contrutor sendo chamado");
            var faker = new Faker("pt_BR");

            _nome = faker.Random.Word();
            _cargaHoraria = faker.Random.Double(50, 1000);
            _publicoAlvo = PublicoAlvo.Estudante;
            _valor = faker.Random.Double(100, 1000);
            _descricao = faker.Lorem.Paragraph();
        }

        public void Dispose()
        {
            _output.WriteLine("Dispose sendo chamado");
        }

        [Fact]
        public void DeveCriarCurso()
        {
            var cursoEspereado = new
            {
                Nome = _nome,
                CargaHoraria = _cargaHoraria,
                PublicoAlvo = _publicoAlvo,
                Valor = _valor,
                Descricao = _descricao
            };

            var curso = new Curso(cursoEspereado.Nome, cursoEspereado.Descricao, cursoEspereado.CargaHoraria, cursoEspereado.PublicoAlvo, cursoEspereado.Valor);

            cursoEspereado.ToExpectedObject().ShouldMatch(curso);
        }


        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCursoTerUmNomeInvalido(string nomeInvalido)
        {
            Assert.Throws<ArgumentException>(() => CursoBuilder.Novo().ComNome(nomeInvalido).Build())
                .ComMensagem("Nome inválido");
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void NaoDeveCursoTerUmaCargaHorariaMenorQue1(double cargaHorariaInvalida)
        {
            Assert.Throws<ArgumentException>(() => CursoBuilder.Novo().ComCargaHoraria(cargaHorariaInvalida).Build())
                .ComMensagem("Carga horária inválida");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void NaoDeveCursoTerValorMenorQue1(double valorInvalido)
        {
            Assert.Throws<ArgumentException>(() => CursoBuilder.Novo().ComValor(valorInvalido).Build())
                .ComMensagem("Valor inválido");
        }
    }
}
