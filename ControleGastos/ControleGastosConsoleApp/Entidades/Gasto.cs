namespace ControleGastosConsoleApp.Entidades
{
    public class Gasto
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public int CategoriaId { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public string FormaPagamento { get; private set; }
        public DateTime Data { get; private set; }

        protected Gasto() { }

        public Gasto(int id, int usuarioId, int categoriaId, string descricao, decimal valor, string formaPagamento, DateTime data)
        {
            Id = id;
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
            Descricao = descricao;
            Valor = valor;
            FormaPagamento = formaPagamento;
            Data = data;
        }
    }
}