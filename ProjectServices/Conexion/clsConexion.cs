using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using ProjectServices.Class;

namespace ProjectServices.Conexion
{
    class clsConexion
    {

        public clsConexion() { }

        public MySqlConnection conector = null;
        public String sConex = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        clsError error = new clsError();

        public MySqlConnection conectarBD()
        {
            try
            {
                conector = new MySqlConnection(sConex);
                conector.Open();
                return conector;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                error.WarningError("Error al Conectar a la Base de Datos " + ex.Message);
                throw new Exception();
            }
        }
        public MySqlConnection desconectarBD()
        {
            try
            {
                conector.Close();
                return conector;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                error.WarningError("Error al Cerrar la Conexion " + ex.Message);
                throw new Exception();
            }
        }


        //public void GeneraraBackup(String file)
        //{

        //    try
        //    {
        //        MySqlConnection conn = new MySqlConnection(sConex);
        //        MySqlCommand cmd = new MySqlCommand();

        //        MySqlBackup mb = new MySqlBackup(cmd);
        //        cmd.Connection = conn;
        //        //conn.Open();
        //        mb.ExportToFile(file);
        //        conn.Close();
        //    }
        //    catch (MySql.Data.MySqlClient.MySqlException ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //public void ImportarBackup(String file)
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(sConex))
        //        {
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                using (MySqlBackup mb = new MySqlBackup(cmd))
        //                {
        //                    cmd.Connection = conn;
        //                    conn.Open();
        //                    mb.ImportFromFile(file);
        //                    conn.Close();
        //                }
        //            }
        //        }
        //        MessageBox.Show("La importación de datos se realizó con ÉXITO!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

    }

}

