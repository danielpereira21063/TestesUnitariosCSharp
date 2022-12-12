using CursoOnline.Dominio;

namespace CursoOnline.Dominio
{
    public interface ICursoRepositorio
    {
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
        Curso ObterPeloNome(string nome);
    }
}