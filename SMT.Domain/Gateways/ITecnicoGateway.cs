using SMT.Domain.Entities;
using SMT.Domain.Queries;

namespace SMT.Domain.Gateways
{
    public  interface ITecnicoGateway
    {
        void Incluir(Tecnico tecnico);

        TecnicoQuery Consultar(string cpf);

        void Alterar(Tecnico tecnico);
    }
}
