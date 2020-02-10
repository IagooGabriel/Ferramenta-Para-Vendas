using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class TipoPagamento{
        [Key]
        public int id_tpPag { get; set; }
        [Required(ErrorMessage = "Este campo é requerido!!")]
        [DisplayName("Tipo de Pagamento")]
        public string nome_tpPag { get; set; }
    }
}
