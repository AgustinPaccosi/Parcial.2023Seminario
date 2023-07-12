using Jardines2023.Comun.Interfaces;
using Jardines2023.Entidades.Dtos.Cliente;
using Jardines2023.Entidades.Dtos.Producto;
using Jardines2023.Entidades.Dtos.Ventas;
using Jardines2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Datos.Repositorios
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private string cadenaConexion;
        public RepositorioVentas()
        {
            cadenaConexion=ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public List<VentaDto> GetListVentas()
        {
            List<VentaDto> lista = new List<VentaDto>();
            using (var con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                string selectQuery = @"Select v.VentaId, v.FechaVenta, v.ClienteId, c.Apellido, v.Total 
                                FROM ventas v
                                inner Join Clientes c on c.ClienteId=V.ClienteId";
                using (var cmd = new SqlCommand(selectQuery, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = new VentaDto()
                            {
                                VentaId = reader.GetInt32(0),
                                FechaVenta = reader.GetDateTime(1),
                                ClienteId = reader.GetInt32(2),
                                Cliente = reader.GetString(3),
                                Total = reader.GetDecimal(4)

                            };
                            lista.Add(venta);
                        }
                    }
                }
            }
            return lista;
        }

        public int GetVentas()
        {
            try
            {
                int cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT(*) FROM Ventas";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<VentaDto> GetVentas(int registrosPorPagina, int paginaActual)
        {
            List<VentaDto> lista = new List<VentaDto>();
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"Select v.VentaId, v.FechaVenta, v.ClienteId, c.Apellido, v.Total 
                        FROM ventas v
                        inner Join Clientes c on c.ClienteId=v.ClienteId
						ORDER BY v.VentaId
                        OFFSET 10 ROWS FETCH NEXT 10 ROWS only";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@cantidadRegistros", SqlDbType.Int);
                        comando.Parameters["@cantidadRegistros"].Value = registrosPorPagina * (paginaActual - 1);

                        comando.Parameters.Add("@cantidadPorPagina", SqlDbType.Int);
                        comando.Parameters["@cantidadPorPagina"].Value = registrosPorPagina;
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var venta = new VentaDto()
                                {
                                    VentaId = reader.GetInt32(0),
                                    FechaVenta = reader.GetDateTime(1),
                                    ClienteId = reader.GetInt32(2),
                                    Cliente = reader.GetString(3),
                                    Total = reader.GetDecimal(4)

                                };
                                lista.Add(venta);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
