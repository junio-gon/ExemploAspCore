using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestruture.API.Data.Models
{
    public class Contato : Base
    {
        [Required]
        [StringLength(50, ErrorMessage = "O tamanho máximo para o campo é {0}")]
        public string? Nome { get; set; }
        public string? Telefone { get; set; }  
        public DateTime? Nascimento { get; set; }
        public string? Email { get; set; }
        public DateTime? CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public bool? IsActive { get; set; }
    }
}
