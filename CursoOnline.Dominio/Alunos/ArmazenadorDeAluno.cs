using CursoOnline.Dominio._Base;
using System;

namespace CursoOnline.Dominio.Alunos
{
    public class ArmazenadorDeAluno
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public ArmazenadorDeAluno(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public void Armazenar(AlunoDto alunoDto)
        {
            var alunoComMesmoCpf = _alunoRepositorio.ObterPeloCpf(alunoDto.Cpf);

            ValidadorDeRegra.Novo()
                .Quando(alunoComMesmoCpf != null && alunoComMesmoCpf.Id != alunoDto.Id, Resources.CpfJaCadastrado)
                .Quando(!Enum.TryParse<PublicoAlvo.PublicoAlvoEnum>(alunoDto.PublicoAlvo, out var publicoAlvoConvertido), Resources.PublicoAlvoInvalido)
                .DispararExcecaoSeExistir();


            if (alunoDto.Id == 0)
            {
                var aluno = new Aluno(alunoDto.Nome, alunoDto.Cpf, alunoDto.Email, publicoAlvoConvertido);
                _alunoRepositorio.Adicionar(aluno);
            }
            else
            {
                var aluno = _alunoRepositorio.ObterPorId(alunoDto.Id);
                aluno.AlterarNome(alunoDto.Nome);
            }
        }
    }
}
