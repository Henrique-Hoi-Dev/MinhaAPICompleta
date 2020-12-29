using System;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IContaFixaService : IDisposable
    {
        Task Adicionar(ContaFixa contaFixa);
        Task Atualizar(ContaFixa contaFixa);
        Task Remover(Guid id);
    }
}