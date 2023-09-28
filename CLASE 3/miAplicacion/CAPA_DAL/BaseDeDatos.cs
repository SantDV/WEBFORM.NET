using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using System.IO;

namespace CAPA_DAL
{
    public class BaseDeDatos
    {


        //Genera la conexión a la base de datos sqlite3.
        //.Si la base de datos no existe la crea junto con su tabla.
        //Esta db se va a crear en la carpeta de archivos temporales del sistema que se ubica en %TEMP%
        public SQLiteConnection Conectar()
        {
            string tempDirectory = Path.GetTempPath();

            string BaseDatos = "DataBase.db";

            string databasePath = Path.Combine(tempDirectory, BaseDatos);

            string connectionString = $"Data Source={databasePath};Version=3;";


            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);


                try
                {

                    SQLiteConnection connection = new SQLiteConnection(connectionString);

                    connection.Open();


                    string createTableQuery = "create table COMPRA(" +
                        "id INTEGER," +
                        "id_item INTEGER," +
                        "nombre TEXT," +
                        "producto TEXT" +
                        ");";

                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);

                    command.ExecuteNonQuery();

                    connection.Close();

                    

                    return connection;


                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    
                }


            }
            else
            {
                try
                {
                    SQLiteConnection connection = new SQLiteConnection(connectionString);
                    return connection;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                   
                }
                
            }

            return null;

        }

        //Busca el ultimo id del detalle de la compra que se haya generado.
        public int UltimoId()
        {
            SQLiteConnection Conn = Conectar();

            Conn.Open();

            string consulta = "SELECT id from compra order by id DESC LIMIT 1;";

            using (SQLiteCommand comando = new SQLiteCommand(consulta, Conn))
            {

                return Convert.ToInt32(comando.ExecuteScalar());
            }
        }

       

        //Abre una conexión con nuestra base de datos sqlite3 y busca el ultimo id generado para guardar los datos de la compra.
        //Si la compra se realizo correctamente la función va a retornar "true", de lo cotrario "false".
        public bool GuardarCompra(DataTable dt)
        {

            SQLiteConnection conn = Conectar();

            int id = UltimoId() + 1;

            string consulta = "INSERT INTO COMPRA(id, id_item, nombre, producto) VALUES (@id, @id_item, @nombre, @producto)";

            conn.Open();

            using (SQLiteCommand comando = new SQLiteCommand(consulta, conn))
            {

                foreach (DataRow row in dt.Rows)
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@id_item", row["idItem"]);
                    comando.Parameters.AddWithValue("@nombre", row["nombre"]);
                    comando.Parameters.AddWithValue("@producto", row["producto"]);

                    comando.ExecuteNonQuery();
                }
                return true;
            }



        }
    }
}
