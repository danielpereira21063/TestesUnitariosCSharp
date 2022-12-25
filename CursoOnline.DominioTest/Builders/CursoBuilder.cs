
using CursoOnline.Dominio.Cursos;
using CursoOnline.Dominio.PublicoAlvo;
using System;
using System.Reflection;

namespace CursoOnline.DominioTest.Builders
{
    public class CursoBuilder
    {
        private int _id;
        public string _nome = "Informática básica";
        public double _cargaHoraria = 80;
        public PublicoAlvoEnum _publicoAlvo = PublicoAlvoEnum.Estudante;
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

        public CursoBuilder ComPublicoAlvo(PublicoAlvoEnum publicoAlvo)
        {
            _publicoAlvo = publicoAlvo;
            return this;
        }

        public Curso Build()
        {
            var curso = new Curso(_nome, _descricao, _cargaHoraria, _publicoAlvo, _valor);

            if(_id > 0)
            {
                var propertyInfo = curso.GetType().GetProperty("Id");
                propertyInfo.SetValue(curso, Convert.ChangeType(_id, propertyInfo.PropertyType), null);
            }

            return curso;
        }

        public CursoBuilder ComId(int id)
        {
            _id = id;
            return this;
        }
    }
}
