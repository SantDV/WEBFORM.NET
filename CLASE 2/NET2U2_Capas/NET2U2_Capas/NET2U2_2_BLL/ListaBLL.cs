using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET2U4_DAL;

namespace NET2U2_2_BLL
{
    public class ListaBLL
    {
        public string AgregarProducto(string producto, int cantidadDeProductos)
        {
            if(cantidadDeProductos < 5)
            {
                BaseDeDatos.EscribirEnBase(producto);
                return "Producto Agregado correctamente";
            }
            else
            {
                return "No se pueden agregar mas productos";
            }
        }

        public void CargarProductos(ref DataTable productos)
        {
            productos = BaseDeDatos.ObtenerProductos();
        }

        public void EliminarProductos()
        {
            BaseDeDatos.EliminarTodo();
        }
    }
}
