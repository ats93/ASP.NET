using Aplicacion.BO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CiudadView : ModelViewPadre
    {
        public List<Ciudad> ciudades;
    }
}
