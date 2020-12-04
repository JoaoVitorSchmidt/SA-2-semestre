using System;
using System.Collections.Generic;

namespace SA.Models
{
    public partial class Cadastro
    {
        //Aqui declaramos as variáveis para a tela de cadastramento
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Areatrabalho { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
