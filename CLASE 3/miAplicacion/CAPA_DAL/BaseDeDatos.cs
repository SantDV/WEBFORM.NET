using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace CAPA_DAL
{
    public class BaseDeDatos
    {
        public SQLiteConnection Conectar()
        {
            string cadena = "Data Source=.\\DatabaseB.db;Version=3;";

            try
            {
                SQLiteConnection conexion = new SQLiteConnection(cadena);
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return null;

        }

        public int UltimoId()
        {
            SQLiteConnection Conn = Conectar();

            Conn.Open();

            string consulta = "SELECT last_insert_rowid() FROM Compra;";

            using (SQLiteCommand comando = new SQLiteCommand(consulta, Conn))
            {

                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

        public bool GuardarCompra(int id, DataTable compra)
        {
            SQLiteConnection Conn = Conectar();

            Conn.Open();

            try
            {
                string consulta = "INSERT INTO COMPRA(id, id_item, nombre, producto) VALUES (@id, @id_item, @nombre, @producto)";

                using (SQLiteCommand comando = new SQLiteCommand(consulta, Conn))
                {

                    foreach (DataRow row in compra.Rows)
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@id_item", row["idItem"]);
                        comando.Parameters.AddWithValue("@nombre", row["nombre"]);
                        comando.Parameters.AddWithValue("@producto", row["item"]);


                        comando.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar datos: " + ex.Message);
                return false;
            }
        }
    }
}
