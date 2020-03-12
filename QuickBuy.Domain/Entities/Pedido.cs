using QuickBuy.Domain.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica(" Crítica - O pedido deve ter peo menos 1 item! ");


            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Campo CEP não pode ser vazio");
            
        }
    }
}
