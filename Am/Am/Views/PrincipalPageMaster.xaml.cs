using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Am.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPageMaster : ContentPage
    {
     

        public PrincipalPageMaster()
        {
            InitializeComponent();
        }


        public void PessoaFisicaClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<PessoaFisicaPage>(new PessoaFisicaPage(), "PessoaFisicaPageAbrir");
            //DisplayAlert("Central de Mensagens", "Mensagem de Pessoa Fisica adicionada na central", "OK");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


        }


        public void PessoaJuridicaClicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<PessoaJuridicaPage>(new PessoaJuridicaPage(), "PessoaJuridicaPageAbrir");
           // DisplayAlert("Central de Mensagens", "Mensagem de Pessoa Juridica adicionada na central", "OK");
        }

        public void SairClicked(object sender, EventArgs e)
        {

            MessagingCenter.Send<String>("", "Logoff");
           // DisplayAlert("Central de Mensagens", "Mensagem de sair adicionada na central", "OK");
        }



    }
}