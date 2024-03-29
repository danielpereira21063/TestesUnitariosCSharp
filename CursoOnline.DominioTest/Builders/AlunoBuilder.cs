﻿using CursoOnline.Dominio.Alunos;
using CursoOnline.Dominio.PublicoAlvo;
using System;
namespace CursoOnline.DominioTest.Builders
{
    public class AlunoBuilder
    {
        private int _id;
        private string _nome = "Daniel Pereira Sanches";
        private PublicoAlvoEnum _publicoAlvo = PublicoAlvoEnum.Estudante;
        private string _cpf = "403.401.560-82";
        private string _email = "danielsanches6301@gmail.com";

        public static AlunoBuilder Novo()
        {
            return new AlunoBuilder();
        }

        public AlunoBuilder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public AlunoBuilder ComEmail(string email)
        {
            _email = email;
            return this;
        }

        public AlunoBuilder ComCpf(string cpf)
        {
            _cpf = cpf;
            return this;
        }

        public AlunoBuilder ComPublicoAlvo(PublicoAlvoEnum publicoAlvo)
        {
            _publicoAlvo = publicoAlvo;
            return this;
        }

        public AlunoBuilder ComId(int id)
        {
            _id = id;
            return this;
        }

        public Aluno Build()
        {
            var aluno = new Aluno(_nome, _cpf, _email, _publicoAlvo);

            if (_id > 0)
            {
                var propertyInfo = aluno.GetType().GetProperty("Id");
                propertyInfo.SetValue(aluno, Convert.ChangeType(_id, propertyInfo.PropertyType), null);
            }

            return aluno;
        }

    }
}
