using System;

namespace Core.Domain
{
    public class Cliente
    {

    
        public string ID { get; set; }
        
        
        public string Telefone { get; set; }

        public string  Nome { get; set; }

        public string Email {get; set;}

        public  string  CPF { get; set; }

        public DateTime DATA_INSERT { get; set; }

        public DateTime DATA_UPDATE { get; set; }

        public DateTime DATA_NASCIMENTO {get; set; }
        
                
        
    }
}