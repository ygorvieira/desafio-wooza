using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface IOperadoraRepository
    {
        List<Operadora> ObterOperadoras();
        Operadora ObterOperadora(int operadoraId);
        void InserirOperadora(Operadora operadora);
        int RemoverOperadora(int operadoraId);
        int AtualizarOperadora(int operadoraId);
    }
}
