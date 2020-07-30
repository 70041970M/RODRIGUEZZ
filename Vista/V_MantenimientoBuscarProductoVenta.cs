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

namespace Rodriguez.Vista
{
    public partial class V_MantenimientoBuscarProductoVenta : Form
    {
        public Int16 id = -1;
        public Int32 idProducto_;
        public string nombreProducto_;
        public int cantidadProducto_;
        public string diseño_;
        public Decimal precioProducto_;
        public Int16 stock_;
        public V_MantenimientoBuscarProductoVenta()
        {
            InitializeComponent();
        }

       
     
        private void FrmMantenimientoBuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void dgbListaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            txtIdProducto.Text = dgbListaProducto.Rows[e.RowIndex].Cells["idProducto"].Value.ToString();
            txtDiseño.Text = dgbListaProducto.Rows[e.RowIndex].Cells["diseño"].Value.ToString();
            txtPrecUnit.Text = dgbListaProducto.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            txtNombrePro.Text = dgbListaProducto.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txtStock.Text = dgbListaProducto.Rows[e.RowIndex].Cells["stock"].Value.ToString();
          

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
                                          , producto.Color
                                          , producto.Tamaño
                                          , producto.Material
                                          , producto.Precio
                                          , producto.Stock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso");
            }
        }
         
                    

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string idpro = txtIdProducto.Text;
            if (idpro == "")
            {
                MessageBox.Show("Por favor seleccione un producto", "aviso");

            }
            else
            {

                int stockk = Int32.Parse(this.txtStock.Text);

                if (stockk > 0)
                {

                    if (nudCantidad.Value != 0)
                    {

                        Int32.TryParse(txtIdProducto.Text, out this.idProducto_);
                        this.diseño_ = txtDiseño.Text;
                        decimal.TryParse(txtPrecUnit.Text, out this.precioProducto_);
                        Int32.TryParse(nudCantidad.Value.ToString(), out this.cantidadProducto_);
                        this.nombreProducto_ = txtNombrePro.Text;
                        this.Close();
                    }
                    else
                        MessageBox.Show("La cantidad no puede ser 0");

                }
                else
                    MessageBox.Show("No cuenta con stock suficiente");


            }
        }

        private void txtNombrePro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgbListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            int  stockactual = Int32.Parse( txtStock.Text);


            if( stockactual < nudCantidad.Value ){
                MessageBox.Show("La cantidad supera el stock ");
                nudCantidad.Value = nudCantidad.Value - 1;
     

            }
        }

     }
 
}

