using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.View
{
    public class ServicoHistoricoModelView{
        public int id_servHist { get; set; }
        public string servicosId { get; set; }
        public string oqfoialterado { get; set; }
        public DateTime dtAlteracao { get; set; }
    }
}
