using ConsultaCep.Model;
using ConsultaCepServices.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCepServices
{
    public class CepApiService: ICepApi
    {
        private const string URL_CONSULTA_CEP = "https://viacep.com.br/";

        public async Task<CepResponse> GetAddressASync(string cep)
        {
            var service = RestService.For<ICepApi>(URL_CONSULTA_CEP);
            return await service.GetAddressASync(cep);
        }
    }
}
