using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodega.BL
{
    public class UbicacionBL
    {
        public List<Ubicacion> ListadeUbicaciones { get; set; }

        public UbicacionBL()
        {
            ListadeUbicaciones = new List<Ubicacion>();
        }

        public void Nueva(Ubicacion ubicacion)
        {
            ListadeUbicaciones.Add(ubicacion);
        }
    }
}

