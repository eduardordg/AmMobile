using Am.Models;
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
            //Validação para passagem dos dados da GlobalViewModel para a RelatorioViewModel
            if ( GlobalViewModel.Relatorio != null)
            {
                this.Resultado = GlobalViewModel.Relatorio.Resultado;
                GlobalViewModel.Relatorio = null;
            }
           
        }


        //declaração de atributo
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

       


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
