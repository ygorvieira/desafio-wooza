using System.Collections.Generic;

namespace Domain.Repository
{
    public interface IPlanoRepository
    {
        List<Plano> ObterPlanos();
        Plano ObterPlano(int planoId);
        void InserirPlano(Plano plano);
        int RemoverPlano(int planoId);
        int AtualizarPlano(int planoId);
    }
}
