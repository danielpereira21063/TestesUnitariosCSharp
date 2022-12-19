using CursoOnline.Dados.Contextos;
using CursoOnline.Dominio.Cursos;
using System.Linq;

namespace CursoOnline.Dados.Repositorios
{
	public class CursoRepositorio : RepositorioBase<Curso>, ICursoRepositorio
	{
		public CursoRepositorio(ApplicationDbContext context) : base(context)
		{
		}

		public Curso ObterPeloNome(string nome)
		{
			var entidade = Context.Set<Curso>().FirstOrDefault(x => x.Nome == nome);
			return entidade;
		}
	}
}
