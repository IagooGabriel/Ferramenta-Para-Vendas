using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class Venda {
        [Key]
        [Required(ErrorMessage = "Este campo é requerido!!")]
        public int id_venda { get; set; }
        [DisplayName("Data da Venda")]
        public DateTime dataVenda { get; set; }
        [DisplayName("Valor")]
        public float valor { get; set; }
        [DisplayName("Parcelas")]
        public int parcelas { get; set; }
        [DisplayName("Tipo Pagamento")]
        public virtual TipoPagamento tipoPagamento { get; set; }
        [DisplayName("Serviços")]
        public virtual Servico servicos { get; set; }
        [DisplayName("Cliente")]
        public virtual Cliente clientes { get; set; }
        [DisplayName("Vendedor")]
        public virtual Vendedor vendedores { get; set; }
        [DisplayName("Preços")]
        public virtual TabelaNegociacao TabelaNegociacao { get; set; }
    }
}
