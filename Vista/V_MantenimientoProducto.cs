using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rodriguez.Controlador;
using Rodriguez.Utilities;
using Rodriguez.Entitites;


namespace Rodriguez.Vista
{
    public partial class V_MantenimientoProducto : Form
    {
        public V_MantenimientoProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Int16 id;
                Int16.TryParse(txtIdProd.Text, out id);

                //---creamos un objeto cliente
                Producto producto = new Producto();

                //--- llenar de datos al objeto cliente
                producto.Categoria = cmbCategoria.Text;
               
                producto.Nombre = txtNombreProd.Text;
                producto.Diseño = txtDiseño.Text;
                producto.Material = txtMaterial.Text;
                producto.Descripcion = txtDescripcionProd.Text;
                // convertidor

                Int16 stock;
                Int16.TryParse(nudStock.Text, out stock);
                producto.Stock = stock;


                decimal precio;
                decimal.TryParse(txtPrecioProd.Text, out precio);
                producto.Precio = precio;
                
                producto.Tamaño = cmbTamaño.Text;
                producto.Color = cmbColor.Text;


                C_Producto C_producto = new C_Producto();

                if (id == 0)
                {

                    //--insertar----

                    Int32 resp = C_producto.C_registrar_producto(producto);

                    txtIdProd.Text = producto.Idproducto.ToString();

                    MessageBox.Show("PRODUCTO REGISTRADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // this.btnEliminar.Enabled = true;


                }
                else
                {

                    //----actualizado

                    producto.Idproducto = id;
                    Int32 resp = C_producto.C_actualizar_producto(producto);

                    MessageBox.Show("PRODUCTO ACTUALIZADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "-" + ex.StackTrace.ToString());
          }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea registrar nuevo Producto?", "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                this.txtIdProd.Clear();
                this.txtNombreProd.Clear();
                this.txtDiseño.Clear();
                this.txtMaterial.Clear();
                this.txtDescripcionProd.Clear();
                this.txtPrecioProd.Clear();
                this.cmbTamaño.SelectedIndex = 0;
                this.cmbCategoria.SelectedIndex = 0;
                this.cmbColor.SelectedIndex = 0;


            }
            else result = DialogResult.No;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
     
            try
            {

                Int16 id;
                Int16.TryParse(txtIdProd.Text, out id);


                if (id > 0)
                {

                    DialogResult dialog;
                    dialog = MessageBox.Show("¿Esta seguro de eliminar este registro?"
                                            , "Confirmacion"
                                            , MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Question);


                    if (dialog == DialogResult.Yes)
                    {

                        C_Producto productoBLL = new C_Producto();
                        productoBLL.C_eliminar_producto(id);
                        MessageBox.Show("PRODUCTO ELIMINADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.txtIdProd.Clear();
                        this.txtNombreProd.Clear();
                        this.txtDiseño.Clear();
                        this.txtMaterial.Clear();
                        this.txtDescripcionProd.Clear();
                        this.txtPrecioProd.Clear();
                        this.cmbTamaño.SelectedIndex = 0;
                        this.cmbCategoria.SelectedIndex = 0;
                        this.cmbColor.SelectedIndex = 0;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }
        }

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                V_MantenimientoBuscarProducto form;
                form = new V_MantenimientoBuscarProducto();

                form.ShowDialog(this);


                if (form.id > 0)
                {

                    C_Producto C_producto = new C_Producto();
                    Producto producto = C_producto.C_buscarPorId_producto(form.id);

                    txtIdProd.Text = producto.Idproducto.ToString();
                    txtNombreProd.Text = producto.Nombre.ToString();
                    txtDiseño.Text = producto.Diseño.ToString();
                    txtMaterial.Text = producto.Material.ToString();
                    txtDescripcionProd.Text = producto.Descripcion.ToString();
                    txtPrecioProd.Text = producto.Precio.ToString();
                    cmbTamaño.Text = producto.Tamaño.ToString();
                    nudStock.Text = producto.Stock.ToString();
                    cmbCategoria.Text = producto.Categoria.ToString();
                    cmbColor.Text = producto.Color.ToString();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");

            }
        
        }

        private void FrmMantenimientoProducto_Load(object sender, EventArgs e)
        {
            this.cmbCategoria.SelectedIndex = 0;
            this.cmbTamaño.SelectedIndex = 0;
            this.btnEliminar.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.cmbColor.SelectedIndex = 0;

        }

        private void txtPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecioProd.Text.Length; i++)
            {
                if (txtPrecioProd.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }
}
