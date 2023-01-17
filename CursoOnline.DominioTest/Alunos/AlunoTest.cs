using Bogus;
using Bogus.Extensions.Brazil;
using CursoOnline.Dominio._Base;
using CursoOnline.Dominio.Alunos;
using CursoOnline.Dominio.PublicoAlvo;
using CursoOnline.DominioTest._Util;
using CursoOnline.DominioTest.Builders;
using ExpectedObjects;
using Xunit;

namespace CursoOnline.DominioTest.Alunos
{
    public class AlunoTest
    {
        private readonly Faker _faker;

        private readonly string _nome;
        private readonly PublicoAlvoEnum _publicoAlvo;
        private readonly string _cpf;
        private readonly string _email;

        public AlunoTest()
        {
            _faker = new Faker();

            _nome = _faker.Name.FullName();
            _publicoAlvo = PublicoAlvoEnum.Estudante;
            _cpf = _faker.Person.Cpf();
            _email = _faker.Person.Email;
        }

        [Fact]
        public void DeveCriarAluno()
        {
            var alunoEsperado = new
            {
                Nome = _nome,
                Cpf = _cpf,
                Email = _email,
                PublicoAlvo = _publicoAlvo
            };

            var aluno = new Aluno(alunoEsperado.Nome,
                         alunoEsperado.Cpf,
                         alunoEsperado.Email,
                         alunoEsperado.PublicoAlvo);

            alunoEsperado.ToExpectedObject().ShouldMatch(aluno);
        }

        [Fact]
        public void DeveAlterarNome()
        {
            var nomeEsperado = _faker.Person.FullName;
            var aluno = AlunoBuilder.Novo().Build();
            aluno.AlterarNome(nomeEsperado);

            Assert.Equal(nomeEsperado, aluno.Nome);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarComNomeInvalido(string nomeInvalido)
        {
            Assert.Throws<ExcecaoDeDominio>(() =>
            {
                AlunoBuilder.Novo().ComNome(nomeInvalido).Build();
            }).ComMensagem(Resources.NomeInvalido);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("email invalido")]
        [InlineData("email@invalido")]
        public void NaoDeveCriarComEmailInvalido(string emailInvalido)
        {
            Assert.Throws<ExcecaoDeDominio>(() =>
            {
                AlunoBuilder.Novo().ComEmail(emailInvalido).Build();
            }).ComMensagem(Resources.EmailInvalido);
        }



        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("CPF Invalido")]
        [InlineData("0000000000")]
        public void NaoDeveCriarComCpfInvalido(string cpfInvalido)
        {
            Assert.Throws<ExcecaoDeDominio>(() =>
            {
                AlunoBuilder.Novo().ComCpf(cpfInvalido).Build();
            }).ComMensagem(Resources.CpfInvalido);
        }

        //[Theory]
        //[InlineData("")]
        //[InlineData(null)]
        //public void NaoDeveAlunoTerNomeInvalido(string nomeInvalido)
        //{
        //    Assert.Throws<ExcecaoDeDominio>(() => AlunoBuilder.Novo().ComNome(nomeInvalido).Build()).ComMensagem(Resources.NomeInvalido);
        //}
    }

}
