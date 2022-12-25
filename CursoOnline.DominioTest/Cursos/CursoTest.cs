using Bogus;
using CursoOnline.Dominio._Base;
using CursoOnline.Dominio.Cursos;
using CursoOnline.Dominio.PublicoAlvo;
using CursoOnline.DominioTest._Util;
using CursoOnline.DominioTest.Builders;
using ExpectedObjects;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    public class CursoTest
    {
        private readonly string _nome;
        private readonly double _cargaHoraria;
        private readonly PublicoAlvoEnum _publicoAlvo;
        private readonly double _valor;
        private readonly string _descricao;

        private readonly Faker _faker;

        public CursoTest()
        {
            _faker = new Faker("pt_BR");

            _nome = _faker.Random.Word();
            _cargaHoraria = _faker.Random.Double(50, 1000);
            _publicoAlvo = PublicoAlvoEnum.Estudante;
            _valor = _faker.Random.Double(100, 1000);
            _descricao = _faker.Lorem.Paragraph();
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
            Assert.Throws<ExcecaoDeDominio>(() => CursoBuilder.Novo().ComNome(nomeInvalido).Build())
                .ComMensagem(Resources.NomeInvalido);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void NaoDeveCursoTerUmaCargaHorariaInvalida(double cargaHorariaInvalida)
        {
            Assert.Throws<ExcecaoDeDominio>(() => CursoBuilder.Novo().ComCargaHoraria(cargaHorariaInvalida).Build())
                .ComMensagem(Resources.CargaHorariaInvalida);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void NaoDeveCursoTerValorMenorQue1(double valorInvalido)
        {
            Assert.Throws<ExcecaoDeDominio>(() => CursoBuilder.Novo().ComValor(valorInvalido).Build())
                .ComMensagem(Resources.ValorInvalido);
        }

        [Fact]
        public void DeveAlterarNome()
        {
            var nomeEsperado = _faker.Person.FullName;
            var curso = CursoBuilder.Novo().Build();

            curso.AlterarNome(nomeEsperado);

            Assert.Equal(nomeEsperado, curso.Nome);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveAlterarComNomeInvalido(string nomeInvalido)
        {
            var curso = CursoBuilder.Novo().Build();

            Assert.Throws<ExcecaoDeDominio>(() => curso.AlterarNome(nomeInvalido))
                .ComMensagem(Resources.NomeInvalido);
        }


        [Fact]
        public void DeveAlterarCargaHoraria()
        {
            var cargaHorariaEsperada = (double)20;
            var curso = CursoBuilder.Novo().Build();

            curso.AlterarCargaHoraria(cargaHorariaEsperada);

            Assert.Equal(cargaHorariaEsperada, curso.CargaHoraria);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void NaoDeveAlterarComCargaHorariaInvalida(double cargaHorariaInvalida)
        {
            var curso = CursoBuilder.Novo().Build();

            Assert.Throws<ExcecaoDeDominio>(() => curso.AlterarCargaHoraria(cargaHorariaInvalida))
                .ComMensagem(Resources.CargaHorariaInvalida);
        }

        [Fact]
        public void DeveAlterarValor()
        {
            var valorEsperado = (double)234.99;
            var curso = CursoBuilder.Novo().Build();

            curso.AlterarValor(valorEsperado);

            Assert.Equal(valorEsperado, curso.Valor);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void NaoDeveAlterarComValorInvalido(double valorInvalido)
        {
            var curso = CursoBuilder.Novo().Build();

            Assert.Throws<ExcecaoDeDominio>(() => curso.AlterarValor(valorInvalido))
                .ComMensagem(Resources.ValorInvalido);
        }
    }
}
