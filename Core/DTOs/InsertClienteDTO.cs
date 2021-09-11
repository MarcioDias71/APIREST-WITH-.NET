using System;

namespace Core.DTOs
{
    public class InsertClienteDTO
    {
        
        public string Telefone { get; set; }

        public string  Nome { get; set; }

        public string Email {get; set;}

        public  string  CPF { get; set; }

        public DateTime DATA_NASCIMENTO {get; set;}
    }
}