namespace ControleGastosConsoleApp.Entidades
{
    public class Receita
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public int CategoriaId { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }

        protected Receita() { }

        public Receita(int id, int usuarioId, int categoriaId, string descricao, decimal valor, DateTime data)
        {
            Id = id;
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }
    }
}
