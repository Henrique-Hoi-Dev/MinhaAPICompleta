using System;

namespace DevIO.Business.Models
{
    public class ContaFixa : Entity
    {
        public Guid id { get; set; }
        public string NomeConta { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}

