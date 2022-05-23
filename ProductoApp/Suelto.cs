using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp
{
     public class Suelto : Producto
    {
        private float medida;

        public Suelto(): base() 
        {
            medida = 0;
        }

        public Suelto(int codigo, string marca, float precioUnitario, float medida) : base(codigo, marca, precioUnitario)
        {
            this.medida = medida;
        }
       
        public float Medida
        {
            get { return medida; }
            set { medida = value; }
        }

        // Estamos sobreescribiendo un comportamiento heredado para especializar:
        public override string ToString()
        {
            return base.ToString() + " |Medida: " + medida;
        }

        // Estamos sobreescribiendo un comportamiento heredado para redefinir:
        public override float GetPrecio()
        {
            return medida * PrecioUnitario;
        }


    }
}
