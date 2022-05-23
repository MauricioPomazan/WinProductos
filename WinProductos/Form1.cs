using ProductoApp;

namespace WinProductos
   
{
    public partial class Form1 : Form
    {
        private const int Cantidad_Maxima = 50;
        private Producto[] productos;



        public Form1()
            
        {
            //inicializar y dibujar todos los controles graficos
            InitializeComponent(); 
            // creamos el vector

            productos = new Producto[Cantidad_Maxima];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           txtCantidad.Enabled = false;
            txtUnidad.Enabled = false;
            rbPack.Checked = true;

        }

        private void rbSuelto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuelto.Checked)
            {
                txtUnidad.Text = String.Empty;
                txtUnidad.Enabled = true;
                txtCantidad.Enabled = false;
            }
        }

        private void rbPack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPack.Checked)
            {
                txtCantidad.Text = String.Empty;
                txtUnidad.Enabled = false;
                txtCantidad.Enabled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto nuevo = null;
            int codigo = int.Parse(txtCodigo.Text);
            string marca = txtMarca.Text;
            float precioUnit = float.Parse(txtPrecioUnit.Text);


            if (rbPack.Checked)//crear un pack
            {
                int cantidad = int.Parse(txtCantidad.Text);
                nuevo = new Pack(codigo, marca, precioUnit, cantidad);
            }
            else //crear un suelto
            {
                int unidad = int.Parse(txtUnidad.Text);
                nuevo = new Pack(codigo, marca, precioUnit, unidad);
            }

            agregarProducto(nuevo);
            lstProductos.Items.Add(nuevo);

            //Faltaria poner todos los textbox
            txtCantidad.Text = String.Empty;
        }

        private void agregarProducto(Producto oProducto)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if(productos[i] == null)
                {
                    productos[i] = oProducto;
                    break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}