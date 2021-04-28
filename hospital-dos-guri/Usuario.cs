using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.ComponentModel;

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

            string query = "SELECT Senha, ID_Usuario, Tipo_Usuario from Usuario WHERE (Nome_Usuario = " + '"' + this.Nome_Usuario + '"'+") AND (Valido = 'v')";

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
            sqlite_datareader.Dispose();
            db.Close();
            return valido;
        }

        public static BindingList<Hospital> PesquisaVagas(string tipoVagas, string nome, string cep, string cidade)
        {
            LocalDatabase db = new LocalDatabase();
            string query = $"SELECT * FROM Hospital WHERE { tipoVagas} > 0";

            if (nome != "") { query += $" AND {nameof(Hospital.Nome_Hospital)} == '{nome}'"; }
            if (cep != "") { query += $" AND {nameof(Hospital.CEP)} == '{cep}'"; }
            if (cidade != "") { query += $" AND {nameof(Hospital.Cidade)} == '{cidade}'"; }

            SQLiteDataReader sqlite_datareader = db.Query(query);

            BindingList<Hospital> hospitais = new BindingList<Hospital>();

            while (sqlite_datareader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.ID_Hospital = (Int64)sqlite_datareader[nameof(Hospital.ID_Hospital)];
                hospital.Nome_Hospital = (string)sqlite_datareader[nameof(Hospital.Nome_Hospital)];
                hospital.Cidade = (string)sqlite_datareader[nameof(Hospital.Cidade)];
                hospital.CEP = (string)sqlite_datareader[nameof(Hospital.CEP)];
                hospital.UTI_Adulto = (Int64)sqlite_datareader[nameof(Hospital.UTI_Adulto)];
                hospital.UTI_Neonatal = (Int64)sqlite_datareader[nameof(Hospital.UTI_Neonatal)];
                hospital.UTI_Pediatrica = (Int64)sqlite_datareader[nameof(Hospital.UTI_Pediatrica)];
                hospital.Emergencia = (Int64)sqlite_datareader[nameof(Hospital.Emergencia)];

                hospitais.Add(hospital);
            }
            sqlite_datareader.Dispose();
            db.Close();
            return hospitais;
        }
    }

    
}
