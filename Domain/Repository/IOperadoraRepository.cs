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
        void RemoverOperadora(int operadoraId);
        void AtualizarOperadora(int operadoraId);
    }
}
