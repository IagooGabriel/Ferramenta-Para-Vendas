using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class VendaParcela{
        [Key]
        public int id_parc { get; set; }
        public int parcelas { get; set; }
        public virtual Venda vendasP { get; set; }
        public DateTime dt_vencimento { get; set; }
        public DateTime dt_pagamento { get; set; }
        public float valor { get; set; }
    }
}
