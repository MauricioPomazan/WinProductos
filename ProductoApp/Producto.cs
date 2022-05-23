using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp
{
    public abstract class Producto
    {
        private int codigo;
        private string marca;
        private float precioUnitario;

        public Producto()
        {
            codigo = 0;
            marca = String.Empty;
            precioUnitario = 0;
        }
        public Producto(int codigo, string marca, float precioUnitario)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.precioUnitario = precioUnitario;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public float PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public override string ToString()
        {
            return "|Còdigo: " + codigo + " |Marca: " + marca + " |Precio unitario: " + precioUnitario; 

        }

        public abstract float GetPrecio();
    }
}
