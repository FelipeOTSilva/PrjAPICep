using ConsultaCep.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep.Facades.Interface
{
    public interface IConsultaCepFacade
    {
        Task<CepResponse> ConsultaCep(string cepInformado);
    }
}
