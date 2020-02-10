using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.Entity
{
    public class TabelaNegociacao{
        [Key]
        public int id_neg { get; set; }
        public virtual Servico servicos { get; set; }
        public virtual Vendedor vendedores { get; set; }
        public float min_porcent { get; set; }
        public float max_porcent { get; set; }
    }
}
