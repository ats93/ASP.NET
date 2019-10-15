using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aplicacion.BO
{
    public class Pais : BOPadre
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public Pais(int id, string nombre) : base(id)
        {
            Nombre = nombre;
        }

    }
}
