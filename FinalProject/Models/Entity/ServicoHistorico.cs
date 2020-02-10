using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class ServicoHistorico{
        [Key]
        public int id_servHist { get; set; }
        public virtual Servico servicos { get; set; }
        public string oqfoialterado{ get; set; }
        public DateTime dtAlteracao { get; set; }
    }
}
