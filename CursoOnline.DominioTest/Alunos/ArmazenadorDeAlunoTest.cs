using Bogus;
using CursoOnline.Dominio.Alunos;
using Moq;

namespace CursoOnline.DominioTest.Alunos
{
    public class ArmazenadorDeAlunoTest
    {
        private readonly ArmazenadorDeAluno _armazenadorDeCurso;
        private readonly Mock<IAlunoRepositorio> _alunoRepositorioMock;
        private readonly Faker _faker;

        public ArmazenadorDeAlunoTest()
        {
            _faker = new Faker("pt-BR");

            _alunoRepositorioMock = new Mock<IAlunoRepositorio>();
            _armazenadorDeCurso = new ArmazenadorDeAluno(_alunoRepositorioMock.Object);
        }
    }
}
