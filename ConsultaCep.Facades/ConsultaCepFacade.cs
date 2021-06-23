using ConsultaCep.Model;
using ConsultaCep.Facades.Interface;
using System.Threading.Tasks;
using ConsultaCepServices;

namespace ConsultaCep.Facades
{
    public class ConsultaCepFacade: IConsultaCepFacade
    {
        public async Task<CepResponse> ConsultaCep(string cepInformado)
        {
            var consulta = await new CepApiService().GetAddressASync(cepInformado);

            return consulta;
        }
    }
}
