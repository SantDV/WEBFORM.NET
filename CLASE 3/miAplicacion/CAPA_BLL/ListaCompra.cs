using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DAL;

namespace CAPA_BLL
{
    internal class ListaCompra
    {

        public bool AgregarCompra(int id, DataTable compra)
        {
            BaseDeDatos baseDeDatos = new BaseDeDatos();

            if (compra == null)
            {
                return baseDeDatos.GuardarCompra(id, compra);
            }
            else
            {
                return false;
            }
        }

    }
}
