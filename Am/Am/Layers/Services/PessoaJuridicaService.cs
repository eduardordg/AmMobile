using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Am.Layers.Services
{
   public class PessoaJuridicaService
    {

        //Mock de chamadas da api, enquanto ela não fica pronta :)
        public string getInfoseg(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para INFOSEG OK :) \n\n";

            return dados;
        }

        public string getArisp(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para ARISP OK :) \n\n";

            return dados;
        }

        public string getCadesp(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para CADESP OK :) \n\n";

            return dados;
        }

        public string getJucesp(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para JUCEPS OK :) \n\n";

            return dados;
        }

        public string getArpensp(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para ARPENSP OK :) \n\n";

            return dados;
        }

        public string getVec(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para VEC OK :) \n\n";

            return dados;
        }

        public string getTre(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para TRE OK :) \n\n";

            return dados;
        }

        public string getCaged(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para CAGED OK :) \n\n";

            return dados;
        }

        public string getCensec(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para CENSEC OK :) \n\n";

            return dados;
        }

        public string getInfocrim(string cnpj)
        {
            //string uri;
            string dados = "Resposta da API para INFOCRIM OK :) \n\n";

            return dados;
        }


        /*  public string GetDados( string cpf)
          {
              var uri = "www.apidorafa.com.br";
              var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(cpf); 
              var conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");
              System.Net.Http.HttpClient client = new HttpClient();
              var resposta = client.PostAsync(uri, conteudoJsonString).Result;
              if (resposta.IsSuccessStatusCode)
              {
                  var resultado = resposta.Content.ReadAsStringAsync().Result;
                  string dados= JsonConvert.DeserializeObject<cpf>(resultado); // Não sei como fazer com string, no exemplo do professor ele usar objeto.
                  return dados;
              }
              else
              {
                  throw new Exception("Dados não encontrados");
              }
          }*/
    }
}
