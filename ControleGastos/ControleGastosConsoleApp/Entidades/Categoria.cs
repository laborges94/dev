namespace ControleGastosConsoleApp.Entidades
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Tipo { get; private set; }
        public DateTime DataCadastro { get; private set; }

        protected Categoria() { }

        public Categoria(int id, string nome, string descricao, string tipo, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
            DataCadastro = dataCadastro;
        }
    }
}