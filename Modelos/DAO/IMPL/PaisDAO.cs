using Aplicacion.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.DAO
{
    public class PaisDAO : DAO, IPaisDAO
    {
        List<Pais> paises;

        public PaisDAO()
        {
            paises = new List<Pais>();

            for (int i = 0; i < 5; i++)
            {
                Pais p = new Pais(i, "Pais" + i);
                paises.Add(p);
            }
        }

        public List<Pais> GetPaises()
        {
            return paises;
        }
    }
}
