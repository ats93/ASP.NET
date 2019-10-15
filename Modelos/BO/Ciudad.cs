using System.ComponentModel.DataAnnotations;

namespace Aplicacion.BO
{
    public class Ciudad : BOPadre
    {

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int PaisId { get; set; }

        public Ciudad(int id, string nombre, int paisId) : base(id)
        { 
            Nombre = nombre;
            PaisId = id;

        }
    }
}
