using MinhaWebAPI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebAPI.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data_cadastro { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Data_nascimento { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; } 
        public string Bairro { get; set; }
        public string Complemento { get; set; } 
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public void RegistrarCliente()
        {
            DAL dal = new DAL();
            string sql = $"INSERT INTO cliente (nome, data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email, cep, logradouro, numero, bairro, complemento, cidade, uf) VALUES('{Nome}', '{Data_cadastro}', '{Cpf_cnpj}', '{Data_nascimento}', '{Tipo}','{Telefone}', '{Email}', '{Cep}', '{Logradouro}', '{Numero}', '{Bairro}','{Complemento}', '{Cidade}', '{Uf}'); ";

            dal.ExecutarComando(sql);
        }

        public List<ClienteModel> ListarClientes()
        {
            var lista = new List<ClienteModel>();

            ClienteModel cliente;


            DAL dal = new DAL();

            string sql = "SELECT * FROM cliente ORDER BY Nome";

            DataTable dados = dal.RetornarDados(sql);

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                cliente = new ClienteModel()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["Id"].ToString()),
                };
            }

        }
    }
}
