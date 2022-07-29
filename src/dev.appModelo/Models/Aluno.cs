using System;

namespace dev.appModelo.Models
{
    public class Aluno
    {
        //configurando para que o id seja gerado randomicamente através do guid
        public Aluno()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }


    }
}
