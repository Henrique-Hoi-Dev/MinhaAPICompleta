using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class ContaFixaRepository : Repository<ContaFixa>, IContaFixaRepository
    {
        public ContaFixaRepository(MeuDbContext context) : base(context) { }


        public async Task<IEnumerable<ContaFixa>> ObterContaFixaFornecedores()
        {
            return await Db.ContaFixa.AsNoTracking().Include(f => f.)
                .OrderBy(p => p.Nome).ToListAsync();
        }
    }
}