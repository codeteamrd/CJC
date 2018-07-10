using LinqToDB;
using Punto_de_ventas.Connection;
using Punto_de_ventas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.ModelsClass
{
    public class Cliente : Conexion
    {

        public List<Clientes> getClientes()
        {
            var query = from c in Cliente
                        select c;
            return query.ToList();

        }

        public void insertCliente(string id, string nombre, string apellido, string direccion, string telefono)
        {
            int pos, idCliente;
            using (var db = new Conexion())
            {
                db.Insert(new Clientes()
                {
                    ID = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Telefono = telefono
                });
                List<Clientes> cliente = getClientes();
                pos = cliente.Count;
                pos--;
                idCliente = cliente[pos].IdCliente;
                db.Insert(new Reportes_Clientes()
                {
                    IdCliente = idCliente,
                    SaldoActual = "$0.00",
                    FechaActual = "Sin fecha",
                    UltimoPago = "$0.00",
                    FechaPago = "Sin fecha",
                    ID = id
                });

            }
        }
    }
}
