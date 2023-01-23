using CursoOnline.Dominio._Base;
using CursoOnline.Dominio.Alunos;
using CursoOnline.Web.Util;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CursoOnline.Web.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ArmazenadorDeAluno _armazenadorDeAluno;
        private readonly IRepositorio<Aluno> _AlunoRepositorio;

        public AlunoController(ArmazenadorDeAluno armazenadorDeAluno, IRepositorio<Aluno> AlunoRepositorio)
        {
            _armazenadorDeAluno = armazenadorDeAluno;
            _AlunoRepositorio = AlunoRepositorio;
        }

        public IActionResult Index()
        {
            var Alunos = _AlunoRepositorio.Consultar();

            if (Alunos.Any())
            {
                var dtos = Alunos.Select(c => new AlunoParaListagemDto
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    Cpf = c.Cpf,
                    PublicoAlvo = c.PublicoAlvo.ToString(),
                    Email = c.Email
                });
                return View("Index", PaginatedList<AlunoParaListagemDto>.Create(dtos, Request));
            }

            return View("Index", PaginatedList<AlunoParaListagemDto>.Create(null, Request));
        }

        public IActionResult Editar(int id)
        {
            var Aluno = _AlunoRepositorio.ObterPorId(id);
            var dto = new AlunoDto
            {
                Id = Aluno.Id,
                Nome = Aluno.Nome,
                Cpf = Aluno.Cpf,
                Email = Aluno.Email,
                PublicoAlvo = Aluno.PublicoAlvo.ToString()
            };
            return View("NovoOuEditar", dto);
        }

        public IActionResult Novo()
        {
            return View("NovoOuEditar", new AlunoDto());
        }

        [HttpPost]
        public IActionResult Salvar(AlunoDto model)
        {
            _armazenadorDeAluno.Armazenar(model);
            return RedirectToAction("Index");
        }
    }
}
