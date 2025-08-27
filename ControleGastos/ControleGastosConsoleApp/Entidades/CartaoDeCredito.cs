namespace ControleGastosConsoleApp.Entidades
{
    public class CartaoDeCredito
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Bandeira { get; private set; }
        public decimal Limite { get; private set; }
        public DateTime Validade { get; private set; }
        public DateTime Vencimento { get; private set; }

        protected CartaoDeCredito() { }

        public CartaoDeCredito(int id, int usuarioId, string nome, DateTime validade, string bandeira,
            decimal limite, DateTime vencimento)
        {
            Id = id;
            UsuarioId = usuarioId;
            Nome = nome;
            Validade = validade;
            Bandeira = bandeira;
            Limite = limite;
            Vencimento = vencimento;
        }
    }
}
