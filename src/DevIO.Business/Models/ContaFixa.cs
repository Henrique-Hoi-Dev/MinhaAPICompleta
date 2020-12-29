using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    internal class ContaFixa : Entity
    {
        public Guid id { get; set; }
        public string NomeConta { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}

