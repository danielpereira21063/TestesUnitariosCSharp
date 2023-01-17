using System.Collections.Generic;

namespace CursoOnline.Dominio._Base
{
    public interface IRepositorio<TEntidade>
    {
        TEntidade ObterPorId(int id);
        List<TEntidade> Consultar();
        void Atualizar(TEntidade entity);
        void Adicionar(TEntidade entity);
    }
}