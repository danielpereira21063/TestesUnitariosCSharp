using CursoOnline.Dominio.Cursos;
using CursoOnline.Web.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace CursoOnline.Web.Controllers
{
    public class CursoController : Controller
    {
        private readonly ArmazenadorDeCurso _armazenadorDeCurso;
        private readonly ICursoRepositorio _cursoRepositorio;

        public CursoController(ArmazenadorDeCurso armazenadorDeCurso, ICursoRepositorio cursoRepositorio)
        {
            _armazenadorDeCurso = armazenadorDeCurso;
            _cursoRepositorio = cursoRepositorio;
        }

        public IActionResult Index()
        {
            var cursos = _cursoRepositorio.Consultar();

            if (cursos.Any())
            {
                var dtos = cursos.Select(c => new CursoParaListagemDto
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    CargaHoraria = c.CargaHoraria,
                    PublicoAlvo = c.PublicoAlvo.ToString(),
                    Valor = c.Valor
                });

                return View("Index", PaginatedList<CursoParaListagemDto>.Create(dtos, Request));
            }

            return View("Index");
        }

        public IActionResult Novo()
        {
            return View("NovoOuEditar");
        }
        
        public IActionResult Editar(int id)
        {
            var curso = _cursoRepositorio.ObterPorId(id);

            var dto = new CursoDto()
            {
                Id = curso.Id,
                CargaHoraria = curso.CargaHoraria,
                Descricao = curso.Descricao,
                Nome = curso.Nome,
                PublicoAlvo = curso.PublicoAlvo.ToString(),
                Valor = curso.Valor
            };

            return View("NovoOuEditar", dto);
        }

        [HttpPost]
        public IActionResult Salvar(CursoDto model)
        {
            _armazenadorDeCurso.Armazenar(model);
            return View("NovoOuEditar");
        }
    }
}
