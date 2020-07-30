using Rodriguez.Controlador;
using Rodriguez.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rodriguez.Modelo;
using Rodriguez.Vista;


namespace Rodriguez.Vista
{
    public partial class V_MantenimientoBuscarProducto : Form
    {
        public Int16 id = -1;


        public V_MantenimientoBuscarProducto()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoBuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void dgbListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgbListaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt16(dgbListaProducto.Rows[e.RowIndex].Cells["idproducto"].Value.ToString());
            this.Close();
        }

        private void txtNombrePro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // detectar si ha presionado la tecla enter
                if (e.KeyCode == Keys.Return)
                {
                    dgbListaProducto.Rows.Clear();

                    C_Producto C_producto = new C_Producto();
                    List<Producto> productos = new List<Producto>();

                    string nombre = txtNombrePro.Text;
                    productos = C_producto.C_buscarPorNombre_producto(nombre);
                    foreach (Producto producto in productos)
                    {
                        dgbListaProducto.Rows.Add(
                                            dgbListaProducto.Rows.Count + 1
                                          , producto.Idproducto
                                          , producto.Nombre
                                          , producto.Diseño
                                          , producto.Material
                                          , producto.Precio
                                          ,producto.Categoria
                                          ,producto.Stock);
                                           
                                          
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Int32.TryParse(txtIdProducto.Text, out this.idProducto_);
            //this.diseño_ = txtDiseño.Text;
            //decimal.TryParse(txtPrecUnit.Text, out this.precioProducto_);
            //Int32.TryParse(nudCantidad.Value.ToString(), out this.cantidadProducto_);
            //this.nombreProducto_ = txtNombrePro.Text;
            //this.Close();
        }
    }
}
