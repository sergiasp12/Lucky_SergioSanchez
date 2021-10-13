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
        [StringLength(100 , MinimumLength =4 ,ErrorMessage ="colocar detalle de 4 a 100")]
        public string Detalle { get; set; }
        [Url]
        public string Imagen { get; set; }
    }
}
