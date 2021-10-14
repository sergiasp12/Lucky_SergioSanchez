using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_SergioSanchez.Models
{
    public class Lucky
    {
        [Key]
        public int SuerteID { get; set; }
 
        [StringLength(800 , MinimumLength = 1 ,ErrorMessage ="colocar detalle de 4 a 100")]
        public string Detalle { get; set; }
        [Url]
        [StringLength(800, MinimumLength = 1, ErrorMessage = "la longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }
    }
}
