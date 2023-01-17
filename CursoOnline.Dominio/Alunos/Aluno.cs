using CursoOnline.Dominio._Base;
using CursoOnline.Dominio._Util;

namespace CursoOnline.Dominio.Alunos
{
    public class Aluno : Entidade
    {
        private string _nome;
        private string _cpf;
        private string _email;
        private PublicoAlvo.PublicoAlvoEnum _publicoAlvo;

        public Aluno(string nome, string cpf, string email, PublicoAlvo.PublicoAlvoEnum publicoAlvo)
        {
            ValidadorDeRegra.Novo()
            .Quando(string.IsNullOrEmpty(nome), Resources.NomeInvalido)
                .Quando(string.IsNullOrEmpty(cpf) || (!string.IsNullOrEmpty(cpf) && !cpf.IsCpf()), Resources.CpfInvalido)
                .Quando(string.IsNullOrEmpty(email) || (!string.IsNullOrEmpty(email) && !email.IsValidEmail()), Resources.EmailInvalido)
                .DispararExcecaoSeExistir();

            _nome = nome;
            _publicoAlvo = publicoAlvo;
            _email = email;
            _cpf = cpf;

            Nome = nome;
            Cpf = cpf;
            Email = email;
            PublicoAlvo = publicoAlvo;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Email { get => _email; set => _email = value; }
        public PublicoAlvo.PublicoAlvoEnum PublicoAlvo { get => _publicoAlvo; set => _publicoAlvo = value; }

        public void AlterarNome(string nome)
        {
            ValidadorDeRegra.Novo()
                .Quando(string.IsNullOrEmpty(nome), Resources.NomeInvalido)
                .DispararExcecaoSeExistir();

            Nome = nome;
        }
    }
}
