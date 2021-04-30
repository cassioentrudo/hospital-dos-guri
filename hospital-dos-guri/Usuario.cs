using System;
using System.ComponentModel;
using System.Data.SQLite;

namespace hospital_dos_guri
{
    enum Tipos_de_Usuario : long { HOSPITAL = 1, GOVERNO = 2 }
    
    /// <summary>
    /// Classe Geral que implementa funções comuns a todos os tipos de Usuário
    /// </summary>
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

        /// <summary>
        /// Função que verifica se as informações de entrada estão corretas e efetua o login
        /// </summary>
        /// <param name="senha"> String com a senha referente ao usuário</param>
        /// <returns></returns>
        public bool EfetuarLogin(string senha)
        {
            bool valido = false;
            LocalDatabase db = new LocalDatabase();

            //Query para selecionar a senha do usuário ao banco
            string query = "SELECT Senha, ID_Usuario, Tipo_Usuario from Usuario WHERE (Nome_Usuario = " + '"' + this.Nome_Usuario + '"'+") AND (Valido = 'v')";

            SQLiteDataReader sqlite_datareader = db.Query(query);
            if(sqlite_datareader.Read())
            {
                //Verifica se a senha entrada está correta
                if ((String.Compare(senha, (string)sqlite_datareader["Senha"]) == 0))
                {
                    //Altera valor de retorno indicando login bem sucedido
                    valido = true;
                    //Altera as informações de tipo e ID de usuário de acordo com o banco
                    this.Tipo_Usuario = (Int64)sqlite_datareader["Tipo_Usuario"];
                    this.ID_Usuario = (Int64)sqlite_datareader["ID_Usuario"];
                }
            }
            sqlite_datareader.Dispose();
            db.Close();
            return valido;
        }

        /// <summary>
        /// Função que busca informações de vagas disponíveis no sistema
        /// </summary>
        /// <param name="tipoVagas"></param>
        /// <param name="nome"></param>
        /// <param name="cep"></param>
        /// <param name="cidade"></param>
        /// <returns>Retorna informações de vagas que condizem com os filtros inseridos</returns>
        public static BindingList<Hospital> PesquisaVagas(string tipoVagas, string nome, string cep, string cidade)
        {
            LocalDatabase db = new LocalDatabase();
            //Cria base da query com tipo de vaga solicitado
            string query = $"SELECT * FROM Hospital WHERE { tipoVagas} > 0";
            //Monta query de acordo com filtros extras solicitados
            if (nome != "") { query += $" AND {nameof(Hospital.Nome_Hospital)} == '{nome}'"; }
            if (cep != "") { query += $" AND {nameof(Hospital.CEP)} == '{cep}'"; }
            if (cidade != "") { query += $" AND {nameof(Hospital.Cidade)} == '{cidade}'"; }

            SQLiteDataReader sqlite_datareader = db.Query(query);

            BindingList<Hospital> hospitais = new BindingList<Hospital>();
            
            //Preenche lista de hospitais que foram lidos com os filtros
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

        /// <summary>
        /// Função que pesquisa informações de tranferencias
        /// Dependendo do tipo de usuário retorna todas as transferencias (tipo governo)
        /// ou as transferencias ligadas ao hospital solicitante (tipo hospital)
        /// </summary>
        /// <returns> Retorna lista de transferencias de acordo com o tipo de usuário</returns>
        public BindingList<Transferencias> PesquisaTransferencias()
        {
            LocalDatabase db = new LocalDatabase();
            string query;

            //Preenche query de solicitação de acordo com tipo de usuário
            if ((Tipos_de_Usuario)this.Tipo_Usuario == Tipos_de_Usuario.GOVERNO)
                 query = $"SELECT * FROM Transferencias ";//WHERE Status == 'p'";
            else
                query = $"SELECT * FROM Transferencias WHERE ID_Hospital_Origem == (SELECT ID_Hospital FROM Hospital WHERE ID_Usuario = {this.ID_Usuario})";
            SQLiteDataReader sqlite_datareader = db.Query(query);

            BindingList<Transferencias> transferencias = new BindingList<Transferencias>();

            //Preenche lista de transferencias com informações lidas
            while (sqlite_datareader.Read())
            {
                Transferencias transferencia = new Transferencias();
                transferencia.ID_Transferencia = (Int64)sqlite_datareader[nameof(Transferencias.ID_Transferencia)];
                transferencia.ID_Hospital_Origem = (Int64)sqlite_datareader[nameof(Transferencias.ID_Hospital_Origem)];
                transferencia.ID_Hospital_Destino = (Int64)sqlite_datareader[nameof(Transferencias.ID_Hospital_Destino)];
                transferencia.UTI_Adulto = (Int64)sqlite_datareader[nameof(Transferencias.UTI_Adulto)];
                transferencia.UTI_Neonatal = (Int64)sqlite_datareader[nameof(Transferencias.UTI_Neonatal)]; 
                transferencia.UTI_Pediatrica = (Int64)sqlite_datareader[nameof(Transferencias.UTI_Pediatrica)];
                transferencia.Emergencia = (Int64)sqlite_datareader[nameof(Transferencias.Emergencia)];
                transferencia.Status = (string)sqlite_datareader[nameof(Transferencias.Status)];

                transferencias.Add(transferencia);
            }
            sqlite_datareader.Dispose();
            db.Close();
            return transferencias;
        }
    }    
}