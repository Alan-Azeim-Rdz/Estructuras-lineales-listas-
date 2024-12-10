namespace Estructuras_lineales__listas_
{
    public partial class Form1 : Form
    {
        private Listas listaProductos;

        public Form1()
        {
            InitializeComponent();
            listaProductos = new Listas();
        }
        private void MostrarProductos()
        {
            // Obtener los productos ordenados
            var productos = listaProductos.ObtenerProductos();

            // Limpiar el DataGridView
            ListViewData.Items.Clear();

            // Mostrar los productos en el DataGridView
            foreach (var producto in productos)
            {
                ListViewData.Items.Add(producto.ToString());
            }
        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            // Crear el producto a partir de los datos ingresados
            string nombre = txtNombre.Text;
            decimal precio = numericUpDownPrecio.Value;

            Producto nuevoProducto = new Producto(nombre, precio);
            listaProductos.Insertar(nuevoProducto);

            // Limpiar los controles
            txtNombre.Clear();
            numericUpDownPrecio.Value = 0;

            MessageBox.Show("Producto insertado correctamente.");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaProductos.OrdenarPorPrecio();
            MostrarProductos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}
