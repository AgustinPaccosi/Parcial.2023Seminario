using Jardines2023.Entidades.Dtos.Proveedor;
using Jardines2023.Entidades.Dtos.Ventas;
using Jardines2023.Servicios.Interfaces;
using Jardines2023.Servicios.Servicios;
using Jardines2023.Windows.Helpers;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardines2023.Windows
{
    public partial class frmVentas : Form
    {

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 2;

        public frmVentas()
        {
            InitializeComponent();
            _servicioVenta = new ServiciosVentas();
        }
        private readonly IServicioVentas _servicioVenta;
        List<VentaDto> lista;

        private void RecargarGrilla()
        {
            try
            {
                //registros = _servicioVenta.GetVentaDtos();
                GridHelper.LimpiarGrilla(dgvDatos);
                foreach (var venta in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, venta);
                    GridHelper.AgregarFila(dgvDatos, r);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void frmVentas_Load(object sender, EventArgs e)
        {
            lista = _servicioVenta.GetVentaDtos();
            RecargarGrilla();
            //MostrarDatosEnGrilla();
        }
        //private void RecargarGrilla()
        //{
        //    try
        //    {
        //        registros = _servicioVenta.GetCantidad();
        //        paginas = FormHelper.CalcularPaginas(registros, registrosPorPagina);
        //        MostrarPaginado();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
            private void MostrarDatosEnGrilla()
        {
            try
            {
                //registros = _servicioVenta.GetVentaDtos();
                GridHelper.LimpiarGrilla(dgvDatos);
                foreach (var venta in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, venta);
                    GridHelper.AgregarFila(dgvDatos, r);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void MostrarPaginado()
        {
            lista = _servicioVenta.GetVentaPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }



        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            paginaActual = paginas;
            MostrarPaginado();

        }

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado();

        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (paginaActual == 1)
            {
                return;
            }
            paginaActual--;
            MostrarPaginado();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual == paginas)
            {
                return;
            }
            paginaActual++;
            MostrarPaginado();

        }
    }
}
