namespace ControleGastosConsoleApp.Entidades
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        protected Usuario() { }

        public Usuario(int id, string nome, string email, string senha, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = dataCadastro;
        }
    }
}