using System;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public class LocalDatabase
    {
        SQLiteConnection sqLite;
        /// <summary>
        /// Inicialização da comunicação com o banco SQLite
        /// Cada instância criada inicia uma comuniucação e a termina ao ser finalizada
        /// </summary>
        public LocalDatabase()
        {
            try
            {
                string localDataPath = Path.GetDirectoryName(Application.ExecutablePath);

                this.sqLite = new SQLiteConnection("Data Source = " + "LocalData.db");
                this.sqLite.Open();
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Função para encerrar manualmente a comunicação com o banco
        /// </summary>
        public void Close()
        {
            this.sqLite.Close();
        }
        /// <summary>
        /// Utilizada para realizar uma busca no banco
        /// </summary>
        /// <param name="query">String que representa a solicitação que será feita ao banco</param>
        /// <returns> Retorna um SQLDataReader com as informações devolvidas pelo banco para a solicitação feita</returns>
        public SQLiteDataReader Query(string query)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = this.sqLite.CreateCommand();
            sqlite_cmd.CommandText = query;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            
            return sqlite_datareader;
        }

        /// <summary>
        /// Função utilizada para fazer querys com o banco que gerem uma atualização do banco
        /// </summary>
        /// <param name="query">String que contém a atualização a ser feita no banco</param>
        public void UpdateQuery(string query)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = this.sqLite.CreateCommand();
            sqlite_cmd.CommandText = query;
            
            sqlite_cmd.ExecuteNonQuery();            
        }
    }
}
