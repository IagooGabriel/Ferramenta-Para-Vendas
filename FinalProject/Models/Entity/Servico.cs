using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models.Entity{
    public class Servico{
        [Key]
        public int id_serv { get; set; }
        public string nome_serv { get; set; }
        public float valor_serv { get; set; }

    }
}
