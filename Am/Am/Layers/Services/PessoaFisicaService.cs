using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Am.Layers.Services
{
   public class PessoaFisicaService
    {

        //metodo mocado enquanto api nao fica pronta
        public string getAll(string cpf)
        {
            string uri;
            string dados="Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getInfoseg(string cpf)
        {
            string uri;
            string dados = "Resposta da API para INFOSEG OK :)";

            return dados;
        }

        public string getArisp(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getCadesp(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getJucesp(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getArpensp(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getVec(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getTre(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getCaged(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getCensec(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

            return dados;
        }

        public string getInfocrim(string cpf)
        {
            string uri;
            string dados = "Chegando até a chamada da API de Pessoa Fisica :)";

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
