using SistemaVentasP2.DAO;
using SistemaVentasP2.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasP2.VISTA
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        void ultimocorrelativodedenta()
        {

            var consultarventa = new ClsDVenta();
            int lista = 0;
            foreach (var list in consultarventa.UltimaVenta())
            {
                lista = list.iDVenta;
            }
            lista++;
            TxtUltimaVenta.Text = lista.ToString();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            ultimocorrelativodedenta();

            

            ClsDCliente clsDDClientes = new ClsDCliente();

            comboBox2.DataSource = clsDDClientes.cargarComboCliente();
            comboBox2.DisplayMember = "nombreCliente";
            comboBox2.ValueMember = "iDCliente";

            ClsDDocumento clsDDocumento = new ClsDDocumento();
            comboBox1.DataSource = clsDDocumento.cargarComboDocumento();
            comboBox1.DisplayMember = "nombreDocumento";
            comboBox1.ValueMember = "iDDocumento";


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarProducto buscar = new FrmBuscarProducto();
                buscar.Show();
                BtnAgregar.PerformClick();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void DtgDeVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DtgDeVentas.CurrentRow.Cells[0].Value.ToString();
            string nombre = DtgDeVentas.CurrentRow.Cells[1].Value.ToString();
            string precio = DtgDeVentas.CurrentRow.Cells[2].Value.ToString();

            FrmMenuu.frmVenta.TxtId.Text = id;
            FrmMenuu.frmVenta.TxtNombreProducto.Text = nombre;
            FrmMenuu.frmVenta.TxtCantidad.Text = precio;
            this.Close();

        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            
           calcular();
        
        }
        void calcular()
            {



            double precio, cantida, total;
                cantida = (double)Convert.ToDecimal(TxtCantidad.Text);
                    precio = (double)Convert.ToDecimal(TxtPrecio.Text);

                    total = precio * cantida;

                    TxtTotal.Text = total.ToString();
                    if (TxtCantidad.Text.Equals("")){
                        TxtCantidad.Text = "1";
                        TxtCantidad.SelectAll();
                    
                }
            }


        void calcularTotal()
        {

            for (int i = 0; i < DtgDeVentas.Rows.Count; i++)
            {

                String datosaoperartotal = DtgDeVentas.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosaoperartotal);

                Double suma = 0;
                suma += DatosConvertidos;

                TxtTotalFinal.Text = suma.ToString();


            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            calcular();
            DtgDeVentas.Rows.Add(TxtId.Text, TxtNombreProducto.Text, TxtPrecio.Text, TxtCantidad.Text, TxtTotal.Text);
            calcularTotal();
            try
            {

                TxtId.Text = "";
                TxtNombreProducto.Clear();
                TxtPrecio.Text = "";
                TxtCantidad.Text="";
                
                TxtTotal.Text = "";

                DtgDeVentas.Refresh();
                DtgDeVentas.ClearSelection();
                int ultimafila = DtgDeVentas.Rows.Count - 1;
                DtgDeVentas.FirstDisplayedScrollingRowIndex = ultimafila;
                DtgDeVentas.Rows[ultimafila].Selected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());




            }

        }


        private void TxtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
           

                if (TxtBuscarProducto.Text.Equals(""))
                {
                    e.Handled = true;

                    BtnBuscar.PerformClick();
             



                }





                else
                {

                    {
                        e.Handled = true;
                        ClsDProducto prod = new ClsDProducto();
                        var busqueda = prod.BuscarProducto(Convert.ToInt32(TxtBuscarProducto.Text));

                        foreach (var iteracion in busqueda)
                        {
                            TxtId.Text = iteracion.idProducto.ToString();
                            TxtNombreProducto.Text = iteracion.nombreProducto;
                            TxtPrecio.Text = iteracion.precioProducto.ToString();
                            TxtCantidad.Text = "i";
                            TxtCantidad.Focus();
                            TxtBuscarProducto.Text = "";
                        }


                    }
                }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                e.Handled = true;
              
                BtnAgregar.PerformClick();
                TxtBuscarProducto.Focus();
            }
        }

        private void TxtBuscarProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (TxtBuscarProducto.Text.Equals(""))
                {
                    e.Handled = true;
                    BtnBuscar.PerformClick();
              
                }

            

            else
            {
                
                {
                        e.Handled = true;
                        ClsDProducto prod = new ClsDProducto();
                    var busqueda = prod.BuscarProducto(Convert.ToInt32(TxtBuscarProducto.Text));

                       

                        if (busqueda.Count<1) {
                            MessageBox.Show("El codigo no existe");
                            TxtBuscarProducto.Text = "";
                        }
                    foreach(var iterar in busqueda)
                    {
                        TxtId.Text = iterar.idProducto.ToString();
                        TxtNombreProducto.Text = iterar.nombreProducto;
                        TxtPrecio.Text = iterar.precioProducto.ToString();
                        TxtCantidad.Text = "1";
                        TxtCantidad.Focus();
                        TxtBuscarProducto.Text = "";

                    }
                }
            }
        }

        private void BtnGuardarVenta_Click(object sender, EventArgs e)
        {
            try { 
            ClsDVenta ventas = new ClsDVenta();
            tb_venta venta = new tb_venta();
            venta.iDDocumento = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            venta.iDCliente = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            venta.iDUsuario = 1;
            venta.totalVenta = Convert.ToDecimal(TxtTotalFinal.Text);
            venta.fecha = Convert.ToDateTime(dtpFecha.Text);
            ventas.save(venta);

                ClsDDetalle detalle = new ClsDDetalle();
                tb_detalleVenta tbDetalle = new tb_detalleVenta();

                foreach (DataGridViewRow dtgv in DtgDeVentas.Rows) {


                    tbDetalle.iDVenta = Convert.ToInt32(TxtUltimaVenta.Text); ;
                    tbDetalle.iDProducto = Convert.ToInt32(dtgv.Cells[0].Value.ToString());
                    tbDetalle.cantidad = Convert.ToInt32(dtgv.Cells[3].Value.ToString());
                    tbDetalle.precio = Convert.ToDecimal(dtgv.Cells[2].Value.ToString());
                    tbDetalle.total = Convert.ToDecimal(dtgv.Cells[4].Value.ToString());
                    detalle.guardardetalleventa(tbDetalle);


                }

                ultimocorrelativodedenta();
                DtgDeVentas.Rows.Clear();
                TxtTotalFinal.Text = "";
        
            MessageBox.Show("Guardado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void TxtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 ) {
                e.Handled = true;
                BtnAgregar.PerformClick();
                TxtBuscarProducto.Focus();
            }
        }

        private void DtgDeVentas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularTotal();
        }
    }
}


    


    
    


