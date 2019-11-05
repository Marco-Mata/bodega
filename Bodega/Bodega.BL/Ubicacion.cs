using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodega.BL
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }

        public Ubicacion(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
