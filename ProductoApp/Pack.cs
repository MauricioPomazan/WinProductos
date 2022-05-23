using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp
{
    public class Pack : Producto
    {
        private int cantidad;

        public Pack() : base()
        {
            cantidad = 0;
        }

        public Pack(int codigo, string marca, float precioUnitario, int cantidad) : base(codigo, marca, precioUnitario)
        {
            this.cantidad = cantidad;
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " |Cantidad: " + cantidad;
        }

        public override float GetPrecio()
        {
            return cantidad * PrecioUnitario; 

        }

    }
}
