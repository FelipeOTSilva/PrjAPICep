using ConsultaCep.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCepServices.Interfaces
{
    public interface ICepApi
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressASync(string cep);
    }
}
