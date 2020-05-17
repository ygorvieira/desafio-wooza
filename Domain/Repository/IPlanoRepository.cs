using System.Collections.Generic;

namespace Domain.Repository
{
    public interface IPlanoRepository
    {
        List<Plano> ObterPlanos();
        Plano ObterPlano(int planoId, int planoDDD);
        Plano ObterPlanoPorTipo(int planoTipo, int planoDDD);
        Plano ObterPlanoPorOperadora(int operadoraID, int planoDDD);
        void InserirPlano(Plano plano);
        int RemoverPlano(int planoId);
        int AtualizarPlano(int planoId);
    }
}
