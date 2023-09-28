using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DAL;

namespace CAPA_BLL
{
    public class ListaCompra
    {

        public bool Compra(DataTable dt)
        {
            BaseDeDatos baseDeDatos = new BaseDeDatos();

            return baseDeDatos.GuardarCompra(dt);
        }

    }
}
