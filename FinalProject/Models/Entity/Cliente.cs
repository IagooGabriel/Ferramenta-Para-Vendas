using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class Cliente{
        [Key]
        public int id_cli { get; set; }
        [Required(ErrorMessage = "Este campo é requerido!!")]
        [DisplayName("Nome Completo")]
        public string nome_cli { get; set; }
        [DisplayName("Contato 1")]
        public string contato_cli { get; set; }
        [DisplayName("Contato 2")]
        public string contato_cli2 { get; set; }
        [DisplayName("Data Cadastro")]
        public DateTime dataCad_cli { get; set; }

    }
}
