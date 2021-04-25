using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace hospital_dos_guri
{
    public class Hospital : Usuario
    {
        public long ID_Hospital { get; set; }
        public string Nome_Hospital { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public long UTI_Adulto { get; set; }
        public long UTI_Neonatal { get; set; }
        public long UTI_Pediatrica { get; set; }
        public long Emergencia { get; set; }

        public Hospital()
        {

        }
        public Hospital(Usuario user)
        {
            this.ID_Usuario = user.ID_Usuario;
            this.Tipo_Usuario = user.Tipo_Usuario;
            this.Nome_Usuario = user.Nome_Usuario;

            LocalDatabase db = new LocalDatabase();
            string query = $"SELECT * FROM Hospital Where ID_Usuario = {this.ID_Usuario}";    

            SQLiteDataReader sqlite_datareader = db.Query(query);
            if (sqlite_datareader.Read())
            {
                this.ID_Hospital = (Int64)sqlite_datareader[nameof(Hospital.ID_Hospital)];
                this.Nome_Hospital = (string)sqlite_datareader[nameof(Hospital.Nome_Hospital)];
                this.Cidade = (string)sqlite_datareader[nameof(Hospital.Cidade)];
                this.CEP = (string)sqlite_datareader[nameof(Hospital.CEP)];
                this.UTI_Adulto = (Int64)sqlite_datareader[nameof(Hospital.UTI_Adulto)];
                this.UTI_Neonatal = (Int64)sqlite_datareader[nameof(Hospital.UTI_Neonatal)];
                this.UTI_Pediatrica = (Int64)sqlite_datareader[nameof(Hospital.UTI_Pediatrica)];
                this.Emergencia = (Int64)sqlite_datareader[nameof(Hospital.Emergencia)];
            }
            sqlite_datareader.Dispose();
            db.Close();
        }

        public void OfertarVagas(int numVagas, string tipoVagas)
        {
            LocalDatabase db = new LocalDatabase();
            string query;
            
            switch (tipoVagas)
            {
                case "Leitos de Emergência":
                    query = $"UPDATE Hospital SET Emergencia = Emergencia + {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.Emergencia += numVagas;
                    break;
                case "Leitos de UTI Adulta":
                    query = $"UPDATE Hospital SET UTI_Adulto = UTI_Adulto + {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.UTI_Adulto += numVagas;
                    break;
                case "Leitos de UTI Neonatal":
                    query = $"UPDATE Hospital SET UTI_Neonatal = UTI_Neonatal + {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.UTI_Neonatal += numVagas;
                    break;
                case "Leitos de UTI Pediatrica":
                    query = $"UPDATE Hospital SET UTI_Pediatrica = UTI_Pediatrica + {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.UTI_Pediatrica += numVagas;
                    break;
                default:
                    query = "SELECT * FROM Hospital";
                    break;

            }
            
            db.UpdateQuery(query);
            db.Close();
        }

        public void CancelarVagas(int numVagas, string tipoVagas)
        {
            LocalDatabase db = new LocalDatabase();
            string query;

            switch (tipoVagas)
            {
                case "Leitos de Emergência":
                    if (numVagas > this.Emergencia)
                        numVagas = (int)this.Emergencia;
                    query = $"UPDATE Hospital SET Emergencia = Emergencia - {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.Emergencia -= numVagas;
                    break;
                case "Leitos de UTI Adulta":
                    if (numVagas > this.UTI_Adulto)
                        numVagas = (int)this.UTI_Adulto;
                    query = $"UPDATE Hospital SET UTI_Adulto = UTI_Adulto - {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.UTI_Adulto -= numVagas;
                    break;
                case "Leitos de UTI Neonatal":
                    if (numVagas > this.UTI_Neonatal)
                        numVagas = (int)this.UTI_Neonatal;
                    query = $"UPDATE Hospital SET UTI_Neonatal = UTI_Neonatal - {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.UTI_Neonatal -= numVagas;
                    break;
                case "Leitos de UTI Pediatrica":
                    if (numVagas > this.UTI_Pediatrica)
                        numVagas = (int)this.UTI_Pediatrica;
                    query = $"UPDATE Hospital SET UTI_Pediatrica = UTI_Pediatrica - {numVagas} WHERE ( ID_Hospital == {this.ID_Hospital})";
                    this.UTI_Pediatrica -= numVagas;
                    break;
                default:
                    query = "SELECT * FROM Hospital";
                    break;

            }
            db.UpdateQuery(query);
            db.Close();
        }

        public static void SolicitaCadastro(string nomeUsuario, string nomeHospital, string senha, string CEP, string cidade)
        {
            LocalDatabase db = new LocalDatabase();
            string query = $"INSERT INTO Usuario (Tipo_usuario,Nome_Usuario,Valido,Senha) Values(1,\"{nomeUsuario}\",'p',\"{senha}\")";
            db.Query(query);

            query = $"INSERT INTO Hospital(ID_Usuario,Nome_Hospital,CEP,Cidade,UTI_Adulto,UTI_Neonatal,UTI_Pediatrica,Emergencia) " +
                $"Values((Select ID_Usuario from Usuario WHERE Nome_Usuario =\"{nomeUsuario}\"),\"{nomeHospital} \",\"{CEP}\",\"{cidade}\",0,0,0,0)";
            db.Query(query);

            db.Close();
        }
    }
}
