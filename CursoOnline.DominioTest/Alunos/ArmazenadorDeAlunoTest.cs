using Bogus;
using Bogus.Extensions.Brazil;
using Bogus.Extensions.Denmark;
using CursoOnline.Dominio._Base;
using CursoOnline.Dominio.Alunos;
using CursoOnline.Dominio.PublicoAlvo;
using CursoOnline.DominioTest._Util;
using CursoOnline.DominioTest.Builders;
using Moq;
using Xunit;

namespace CursoOnline.DominioTest.Alunos
{
    public class ArmazenadorDeAlunoTest
    {
        private readonly ArmazenadorDeAluno _armazenadorDeAluno;
        private readonly Mock<IConversorDePublicoAlvo> _conversorPublicoAlvoMock;
        private readonly Mock<IAlunoRepositorio> _alunoRepositorioMock;
        private readonly Faker _faker;

        private readonly AlunoDto _alunoDto;

        public ArmazenadorDeAlunoTest()
        {
            _faker = new Faker("pt_BR");

            _alunoDto = new AlunoDto
            {
                Nome = _faker.Person.FullName,
                Email = _faker.Person.Email,
                Cpf = _faker.Person.Cpf(),
                PublicoAlvo = PublicoAlvoEnum.Empregado.ToString()
            };

            _alunoRepositorioMock = new Mock<IAlunoRepositorio>();
            _conversorPublicoAlvoMock = new Mock<IConversorDePublicoAlvo>();
            _armazenadorDeAluno = new ArmazenadorDeAluno(_alunoRepositorioMock.Object, _conversorPublicoAlvoMock.Object);
        }

        [Fact]
        public void DeveAdicionarAluno()
        {
            _armazenadorDeAluno.Armazenar(_alunoDto);

            _alunoRepositorioMock.Verify(r => r.Adicionar(It.Is<Aluno>(a => a.Nome == _alunoDto.Nome)));
        }

        [Fact]
        public void NaoDeveAdicionarAlunoComMesmoCpfDeOutroJaSalvo()
        {
            var alunoJaSalvo = AlunoBuilder.Novo().ComId(_faker.Random.Int(1, 999999999)).Build();

            _alunoRepositorioMock.Setup(c => c.ObterPeloCpf(_alunoDto.Cpf)).Returns(alunoJaSalvo);

            Assert.Throws<ExcecaoDeDominio>(() => _armazenadorDeAluno.Armazenar(_alunoDto))
                .ComMensagem(Resources.CpfJaCadastrado);
        }

        [Fact]
        public void DeveEditarAluno()
        {
            _alunoDto.Id = 35;
            _alunoDto.Nome = _faker.Person.FullName;
            var alunoJaSalvo = AlunoBuilder.Novo().Build();
            _alunoRepositorioMock.Setup(r => r.ObterPorId(_alunoDto.Id)).Returns(alunoJaSalvo);

            _armazenadorDeAluno.Armazenar(_alunoDto);
            Assert.Equal(_alunoDto.Nome, alunoJaSalvo.Nome);
        }

        [Fact]
        public void NaoDeveAdicionarQuandoForEdicao()
        {
            _alunoDto.Id = 35;
            var alunoJaSalvo = AlunoBuilder.Novo().Build();
            _alunoRepositorioMock.Setup(r => r.ObterPorId(_alunoDto.Id)).Returns(alunoJaSalvo);

            _armazenadorDeAluno.Armazenar(_alunoDto);

            _alunoRepositorioMock.Verify(r => r.Adicionar(It.IsAny<Aluno>()), Times.Never);
        }


        [Fact]
        public void NaoDeveAlterarTodosCamposDoAluno()
        {
            _alunoDto.Cpf = _faker.Person.Cpf();

            var aluno = AlunoBuilder.Novo().ComCpf(_alunoDto.Cpf).Build();
            _alunoRepositorioMock.Setup(c => c.ObterPorId(_alunoDto.Id)).Returns(aluno);

            _armazenadorDeAluno.Armazenar(_alunoDto);

            Assert.Equal(_alunoDto.Cpf, aluno.Cpf);
        }

        [Fact]
        public void NaoDeveAdicionarNoRepositorioQuandoOCursoJaExiste()
        {
            _alunoDto.Id = _faker.Random.Int(1, 999999999);
            var aluno = AlunoBuilder.Novo().Build();
            _alunoRepositorioMock.Setup(c => c.ObterPorId(_alunoDto.Id)).Returns(aluno);

            _armazenadorDeAluno.Armazenar(_alunoDto);

            _alunoRepositorioMock.Verify(c => c.Adicionar(It.IsAny<Aluno>()), Times.Never);
        }
    }
}
