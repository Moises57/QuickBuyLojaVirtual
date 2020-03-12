namespace QuickBuy.Domain.Entities
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O produto deve ter um nome");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("O produto deve ter uma Descrição");

            if (Preco == 0)
                AdicionarCritica("O preço do produto tem que ser maior que 0");
        }
    }
}
