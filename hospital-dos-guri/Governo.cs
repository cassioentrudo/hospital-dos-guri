using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.ComponentModel;

namespace hospital_dos_guri
{
    public class Governo: Usuario
    {

        public Governo(Usuario user)
        {
            this.ID_Usuario = user.ID_Usuario;
            this.Tipo_Usuario = user.Tipo_Usuario;
            this.Nome_Usuario = user.Nome_Usuario;
        }
        
        /// <summary>
        /// Classe que solicita ao banco todos os usuários com registro pendente 
        /// </summary>
        /// <returns> Retonar uma lista de hospitais com Cadastro pendente</returns>
        public BindingList<Hospital> ListaUsuariosPendentes()
        {
            //Criação de query para selecionar informações de hospitais pendentes
            string query = "SELECT * FROM Usuario JOIN Hospital ON Usuario.ID_Usuario = Hospital.ID_Usuario WHERE Valido = 'p'";

            LocalDatabase db = new LocalDatabase();
            SQLiteDataReader sqlite_datareader = db.Query(query);

            BindingList<Hospital> hospitais = new BindingList<Hospital>();

            //Preenche lista lendo informações recebidas do banco de dados
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
        /// Classe responsável por enviar ao banco de dados uma solicitação
        /// de alterar o estado de um cadastro pendente no banco
        /// </summary>
        /// <param name="idHospital"> Id do hospital que será atualizado</param>
        /// <param name="novoValido"> Novo estado para a validade do Cadastro
        /// 'v' -> Valido
        /// 'i' -> inválido</param>
        public void ValidaCadastro(long idHospital, char novoValido)
        {
            //criação dinamida da query com as informações de entrada
            string query = $"UPDATE Usuario SET Valido ='{novoValido}'  WHERE ID_Usuario = (SELECT ID_Usuario FROM Hospital WHERE ID_Hospital = {idHospital} )";

            LocalDatabase db = new LocalDatabase();

            db.UpdateQuery(query);
            db.Close();

        }
    }
}
