using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace hospital_dos_guri
{
    enum Tipos_de_Usuario : long { HOSPITAL = 1, GOVERNO = 2 }
    public class Usuario
    {

        public long ID_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public long Tipo_Usuario { get; set; }

        public Usuario(string nome_usuario)
        {
            this.Nome_Usuario = nome_usuario;
        }
        public Usuario()
        {
            
        }

        public bool EfetuarLogin(string senha)
        {
            bool valido = false;
            LocalDatabase db = new LocalDatabase();

            string query = "SELECT Senha, ID_Usuario, Tipo_Usuario from Usuario WHERE Nome_Usuario = " + '"' + this.Nome_Usuario + '"';

            SQLiteDataReader sqlite_datareader = db.Query(query);
            if(sqlite_datareader.Read())
            {
                if ((String.Compare(senha, (string)sqlite_datareader["Senha"]) == 0))
                {
                    valido = true;
                    this.Tipo_Usuario = (Int64)sqlite_datareader["Tipo_Usuario"];
                    this.ID_Usuario = (Int64)sqlite_datareader["ID_Usuario"];
                }
            }

            return valido;
        }
    }

    
}
