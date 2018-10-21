using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        public Producto[] inventario { private set; get; }

        public Inventario()
        {
            inventario = new Producto[20];
        }

        public bool agregar(Producto producto)
        {
            if (buscarPosición(producto.código) == -1 && total() < inventario.Length)
            {
                inventario[total()] = producto;
                return true;
            }
            else
                return false;
        }

        private int buscarPosición(int código)
        {
            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] != null && inventario[i].código == código)
                    return i;
            }
            return -1;
        }

        public Producto buscarProducto(int código)
        {
            int pos = buscarPosición(código);

            if (pos > -1)
                return inventario[pos];
            else
                return null;
        }

        public bool eliminar(int código)
        {
            int pos = buscarPosición(código);

            if (pos > -1)
            {
                for (int i = pos; i < inventario.Length - 1; i++)
                {
                    inventario[i] = inventario[i + 1];
                }
                inventario[inventario.Length - 1] = null;
                return true;
            }
            else
                return false;
        }

        public bool insertar(Producto producto, int pos)
        {
            if (buscarPosición(producto.código) == -1 && total() < inventario.Length)
            {
                for (int i = inventario.Length - 1; i >= pos + 1; i--)
                {
                    inventario[i] = inventario[i - 1];
                }
                inventario[pos] = producto;
                return true;
            }
            else
                return false;
        }

        public int total()
        {
            int total = 0;
            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] != null)
                    total++;
                else
                    break;
            }
            return total;
        }

        public override string ToString()
        {
            string reporte = "";
            for (int i = 0; i < inventario.Length; i++)
            {
                if (inventario[i] != null)
                    reporte += inventario[i].ToString() + Environment.NewLine;
                else
                    break;
            }
            return reporte;
        }
    }
}