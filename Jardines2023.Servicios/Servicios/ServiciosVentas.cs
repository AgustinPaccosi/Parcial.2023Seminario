using Jardines2023.Comun.Interfaces;
using Jardines2023.Comun.Repositorios;
using Jardines2023.Datos.Repositorios;
using Jardines2023.Entidades.Dtos.Ventas;
using Jardines2023.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Servicios.Servicios
{
    public class ServiciosVentas : IServicioVentas
    {
        private readonly IRepositorioVentas _repositorioVentas;
        //public ServiciosProveedores()
        //{
        //    _repositorio = new RepositorioProveedores();
        //}
        public ServiciosVentas()
        {
            _repositorioVentas= new RepositorioVentas();
        }

        public int GetCantidad()
        {
            try
            {
                return _repositorioVentas.GetVentas();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<VentaDto> GetVentaDtos()
        {
            try
            {
                return _repositorioVentas.GetListVentas();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<VentaDto> GetVentaPorPagina(int registrosPorPagina,  int paginaActual)
        {
            try
            {
                return _repositorioVentas.GetVentas(registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /*            try
            {
                return _repositorio.GetClientes(paisFiltro, ciudadFiltro);
            }
            catch (Exception)
            {

                throw;
            }
*/
    }
}
