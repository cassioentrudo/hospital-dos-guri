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

        public void Close()
        {
            this.sqLite.Close();
        }

        public SQLiteDataReader Query(string query)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = this.sqLite.CreateCommand();
            sqlite_cmd.CommandText = query;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            
            return sqlite_datareader;
        }

        public void UpdateQuery(string query)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = this.sqLite.CreateCommand();
            sqlite_cmd.CommandText = query;
            
            sqlite_cmd.ExecuteNonQuery();            
        }
    }
}
