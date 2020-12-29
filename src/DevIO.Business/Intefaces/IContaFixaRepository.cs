﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IContaFixaRepository : IRepository<ContaFixa>
    {
        Task<IEnumerable<ContaFixa>> ObterContaFixaFornecedores();
    }
}