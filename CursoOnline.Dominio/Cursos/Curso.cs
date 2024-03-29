﻿using CursoOnline.Dominio._Base;
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
        public PublicoAlvo.PublicoAlvoEnum PublicoAlvo { get; private set; }
        public double Valor { get; private set; }


        public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvo.PublicoAlvoEnum publicoAlvo, double valor)
        {
            ValidadorDeRegra.Novo()
                .Quando(string.IsNullOrEmpty(nome), Resources.NomeInvalido)
                .Quando(cargaHoraria < 1, Resources.CargaHorariaInvalida)
                .Quando(valor < 1, Resources.ValorInvalido)
                .DispararExcecaoSeExistir();

            //if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");

            //if (cargaHoraria < 1) throw new ArgumentException("Carga horária inválida");

            //if (valor < 1) throw new ArgumentException("Valor inválido");

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
            Descricao = descricao;
        }

        public void AlterarNome(string nome)
        {
            ValidadorDeRegra.Novo()
                .Quando(string.IsNullOrEmpty(nome), Resources.NomeInvalido)
                .DispararExcecaoSeExistir();

            Nome = nome;
        }

        public void AlterarCargaHoraria(double cargaHoraria)
        {
            ValidadorDeRegra.Novo()
                .Quando(cargaHoraria < 1, Resources.CargaHorariaInvalida)
                .DispararExcecaoSeExistir();

            CargaHoraria = cargaHoraria;
        }

        public void AlterarValor(double valor)
        {
            ValidadorDeRegra.Novo()
                .Quando(valor < 1, Resources.ValorInvalido)
                .DispararExcecaoSeExistir();

            Valor = valor;
        }
    }
}
