using System.Collections.Generic;

namespace Domain.Repository
{
    public interface IPlanoRepository
    {
        List<Plano> ObterPlanos();
        Plano ObterPlano(int planoId);
        void InserirPlano(Plano plano);
        void RemoverPlano(int planoId);
        void AtualizarPlano(int planoId);
    }
}
