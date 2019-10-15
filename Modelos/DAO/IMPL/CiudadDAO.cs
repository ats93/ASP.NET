using Aplicacion.BO;
using System.Collections.Generic;

namespace Aplicacion.DAO
{
    public class CiudadDAO : DAO, ICiudadDAO
    {
        List<Ciudad> ciudades;

        public CiudadDAO()
        {
            ciudades = new List<Ciudad>();

            for (int i = 0; i < 5; i++)
            {
                Ciudad c = new Ciudad(i, "ciudad" + i, i);
                ciudades.Add(c);
            }
        }

        public List<Ciudad> GetCiudades()
        {
            return ciudades;
        }
    }
}
