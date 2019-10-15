using Aplicacion.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebApplication1.Models
{
    public class PaisView : ModelViewPadre
    {

        public List<Pais> paises;

        public List<Ciudad> ciudades;

    }
}
