namespace ControleGastosConsoleApp.Entidades
{
    public class ObjetivoFinanceiro
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal ValorObjetivo { get; private set; }
        public decimal ValorAtual { get; private set; }
        public DateTime DataLimite { get; private set; }

        protected ObjetivoFinanceiro() { }

        public ObjetivoFinanceiro(int id, int usuarioId, string nome, decimal valorObjetivo, decimal valorAtual,
            DateTime dataLimite, string descricao)
        {
            Id = id;
            UsuarioId = usuarioId;
            Nome = nome;
            ValorObjetivo = valorObjetivo;
            ValorAtual = valorAtual;
            DataLimite = dataLimite;
            Descricao = descricao;
        }
    }
}
