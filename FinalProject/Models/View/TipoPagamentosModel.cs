using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.View
{
    public class TipoPagamentosModel{
        public int id_venda { get; set; }
        [DisplayName("Data da Venda")]
        public DateTime dataVenda { get; set; }
        [DisplayName("Valor")]
        public float valor { get; set; }
        [DisplayName("Parcelas")]
        public int parcelas { get; set; }
        [DisplayName("Tipo de Pagamento")]
        public string tipoPagamentoId { get; set; }
        [DisplayName("Serviço")]
        public string servicosId { get; set; }
        [DisplayName("Vendedor")]
        public string vendedoresId { get; set; }
        [DisplayName("Cliente")]
        public string clientesId { get; set; }
        public string tabelaNegociacaoId { get; set; }
    }
}
