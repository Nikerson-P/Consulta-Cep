using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta_Cep
{
    /*
     * "cep": "01001-000",
      "logradouro": "Praça da Sé",
      "complemento": "lado ímpar",
      "bairro": "Sé",
      "localidade": "São Paulo",
      "uf": "SP",
      "ibge": "3550308",
      "gia": "1004",
      "ddd": "11",
      "siafi": "7107"
      */
    class Cep
    {
        public string cep;
        public string logradouro;
        public string complemento;
        public string bairro;
        public string localidade;
        public string uf;
        public string ibge;
        public string gia;
        public string ddd;
        public string siafi;


        public override string ToString()
        {
            return $"CEP:{cep}\n" +
                $"Logradouro:{logradouro}\n" +
                $"Complemento:{complemento}\n" +
                $"Bairro:{bairro}\n " +
                $"Localidade:{localidade}\n " +
                $"UF:{uf}\n " +
                $"IBGE:{ibge}\n " +
                $"GIA:{gia}\n " +
                $"DDD:{ddd}\n " +
                $"SIAFI:{siafi}\n";
        }
    }
}
