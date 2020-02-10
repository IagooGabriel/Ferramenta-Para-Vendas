using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.View
{
    public class TabelaNgociacoesViewModel
    {
        public int id_neg { get; set; }
        public string ServicoId  { get; set; }
        public string VendedorId { get; set; }
        public float min_porcent { get; set; }
        public float max_porcent { get; set; }
    }
}
