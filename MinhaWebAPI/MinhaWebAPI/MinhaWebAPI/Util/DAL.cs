using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Util
{
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "dbcliente";
        private static string User = "root";
        private static string Password = "";
        private MySqlConnection Connection;

        private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;";


        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }
        
        public void ExecutarComando(string sql)
        {
            var command = new MySqlCommand(sql, Connection);
            command.ExecuteNonQuery();
        }

        public DataTable RetornarDados(string sql)
        {
            var command = new MySqlCommand(sql, Connection); 
            var dataAdapter = new MySqlDataAdapter(command);
            var dados = new DataTable();
            dataAdapter.Fill(dados);
            return dados;
        }
    }
}
