using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

//Utilizo un archivo de texto como base de datos como ejemplo. 
//En el futuro puedo cambiar el archivo de texto por una base de datos real modificando el proyecto DAL 
//sin tener que modificar lo demás gracias a la separación de capas y el uso de DataTables

namespace NET2U4_DAL
{
    public class BaseDeDatos
    {
        public static StreamWriter db;
        public static StreamReader dbr;

        public static void Conectar()
        {
            db = File.AppendText(@"db.db");
        }

        public static void EscribirEnBase(string texto)
        {
            Conectar();
            db.WriteLine(texto);
            Desconectar(db);
        }


        public static void Desconectar(StreamWriter db)
        {
            db.Close();
        }

        public static DataTable ObtenerProductos()
        {
            if (File.Exists(@"db.txt"))
            {
                DataTable dt = new DataTable("Productos");

                dt.Columns.Add("Producto");
                foreach (string item in File.ReadAllLines(@"db.txt").ToList<string>())
                {
                    dt.Rows.Add(item);
                }
                return dt;

            }
            else
                return null;
        }

        public static void EliminarTodo()
        {
            File.Delete(@"db.db");
        }
    }
}
