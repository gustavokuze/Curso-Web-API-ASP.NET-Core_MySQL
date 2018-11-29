using System;
using System.Collections.Generic;
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
    }
}
