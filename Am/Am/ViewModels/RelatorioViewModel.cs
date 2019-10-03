using Am.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Am.ViewModels
{
    public class RelatorioViewModel : INotifyPropertyChanged
    {

        public RelatorioViewModel()
        {


           
            // resultado = "Nome : Antonio Jacinto Wesley \n\nData de nascimento : 18/04/1980 \n\nEndereço: Rua dos bobos nº0 \n\nRG: 12345679-X \n\nTelefone: (11) 4002-8922 \n\nEmail: abc@abc.com.br \n\nEmpregado em: - \n\nSocio na(s) empresa(s): PAGSEGURO \n\nCNPJ: 12345678910 \n\nContador: Wellington Muniz \n\nTítulo de Eleitor: 12345678910 \n\nLocal de votação: Rua Ari Toledo 123 - São Paulo - SP \n\nLocal de multas: Rua Arti 5454 - Niterói, RJ";
            //resultado = "Infelizmente não encontramos nenhuma informação";
        }



        private string resultado;
        public string Resultado
        {
            get { return resultado; }
            set
            {
               
                    resultado = value;
                    NotifyPropertyChanged();
                
            }
        }

        public void receberDadosCpf(string dadosEncontrados) {

            resultado = dadosEncontrados;
            DependencyService.Get<IMessage>().ShortAlert(resultado);

        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
