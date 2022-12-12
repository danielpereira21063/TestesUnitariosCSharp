using CursoOnline.Dominio;
using CursoOnline.DominioTest.Cursos;

namespace CursoOnline.DominioTest.Builders
{
    public class CursoBuilder
    {
        public string _nome = "Informática básica";
        public double _cargaHoraria = 80;
        public PublicoAlvo _publicoAlvo = PublicoAlvo.Estudante;
        public double _valor = 950;
        public string _descricao = "Uma descrição";


        public static CursoBuilder Novo()
        {
            return new CursoBuilder();
        }

        public CursoBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public CursoBuilder ComDescricao(string descricao)
        {
            _descricao = descricao;
            return this;
        }

        public CursoBuilder ComCargaHoraria(double cargaHoraria)
        {
            _cargaHoraria = cargaHoraria;
            return this;
        }

        public CursoBuilder ComValor(double valor)
        {
            _valor = valor;
            return this;
        }

        public CursoBuilder ComPublicoAlvo(PublicoAlvo publicoAlvo)
        {
            _publicoAlvo = publicoAlvo;
            return this;
        }

        public Curso Build()
        {
            return new Curso(_nome, _descricao, _cargaHoraria, _publicoAlvo, _valor);
        }
    }
}
