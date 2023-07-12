using Jardines2023.Entidades.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Servicios.Interfaces
{
    public interface IServicioVentas
    {
        int GetCantidad();
        List<VentaDto> GetVentaDtos();
        List<VentaDto> GetVentaPorPagina(int cantidad, int pagina);

    }
}
