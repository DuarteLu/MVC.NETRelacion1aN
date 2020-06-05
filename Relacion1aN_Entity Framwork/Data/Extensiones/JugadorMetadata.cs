using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class JugadorMetadata
    {
        [Required(ErrorMessage = "Ingrese Apellido")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Range(18, 45)]
        public int Edad { get; set; }
    }


    }