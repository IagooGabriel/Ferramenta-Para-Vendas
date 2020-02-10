using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class Vendedor {
        [Key]
        public int id_vend { get; set; }
        public string nome_vend { get; set; }
        public bool ativo { get; set; }
    }
}
