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
    public partial class PrincipalPage : MasterDetailPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
           
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Abrindo tela de Pessoa Fisica
            MessagingCenter.Subscribe<PessoaFisicaPage>(this,
                    "PessoaFisicaPageAbrir",
                    (sender) =>
                    {
                        this.Detail = new NavigationPage(new PessoaFisicaPage());
                        this.IsPresented = false;
                    });


            // Abrindo tela de Pessoa Juridica
            MessagingCenter.Subscribe<PessoaJuridicaPage>(this, "PessoaJuridicaPageAbrir",
                (sender) =>
                {
                    this.Detail = new NavigationPage(new PessoaJuridicaPage());
                    this.IsPresented = false;


                });

           





        }


    }
}