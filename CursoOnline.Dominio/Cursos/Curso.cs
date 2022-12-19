using CursoOnline.Dominio._Base;
using CursoOnline.Dominio.PublicoAlvo;
using System;

namespace CursoOnline.Dominio.Cursos
{
    public class Curso : Entidade
    {
        private Curso()
        {

        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvoEnum PublicoAlvo { get; private set; }
        public double Valor { get; private set; }


        public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvoEnum publicoAlvo, double valor)
        {
            ValidadorDeRegra.Novo()
                .Quando(string.IsNullOrEmpty(nome), "Nome inválido")
                .Quando(cargaHoraria < 1, "Carga horária inválida")
                .Quando(valor < 1, "Valor inválido");

            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");

            if (cargaHoraria < 1) throw new ArgumentException("Carga horária inválida");

            if (valor < 1) throw new ArgumentException("Valor inválido");

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
