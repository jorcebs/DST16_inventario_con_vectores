using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        public int código { private set; get; }
        public string nombre { private set; get; }
        public int cantidad { private set; get; }
        public int costo { private set; get; }

        public Producto(int código, string nombre, int cantidad, int costo)
        {
            this.código = código;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.costo = costo;
        }

        public override string ToString()
        {
            return código.ToString() + "\t" + nombre + "\t" + cantidad.ToString() + "\t" + costo.ToString();
        }
    }
}
