using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Am.Views;
using Am.Views.Components;
using Am.ViewModels;

namespace Am
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

           
            //  Comentários para facilitar a escolha da MainPage

            // MainPage = new Am.Views.RelatorioPage();

             MainPage = new Am.Views.LoginPage();

          //  MainPage = new Am.Views.PrincipalPage();


        }

        protected override void OnStart()
        {

            // Handle when your app starts
            MessagingCenter.Subscribe<LoginViewModel>(this, "LoginSucesso",
                (sender) =>
                {
                    DependencyService.Get<IMessage>().ShortAlert("Teste Subscribe");
                    MainPage = new PrincipalPage();
                });

            // Handle when your app starts
            MessagingCenter.Subscribe<String>("", "Logoff",
                (sender) =>
                {

                    // new LogoffBusiness().Logoff();

                    MainPage = new LoginPage();
                });

            // Handle when your app starts
            MessagingCenter.Subscribe<PessoaFisicaViewModel>(this, "RelatorioPageAbrir",
                (sender) =>
                {

                    
                    var principalPage = new PrincipalPage();

                    principalPage.Detail = new NavigationPage(new RelatorioPage());
                    principalPage.IsPresented = false;

                   MainPage = principalPage;
                });

            MessagingCenter.Subscribe<PessoaJuridicaViewModel>(this, "RelatorioPageAbrir",
               (sender) =>
               {

                   var principalPage = new PrincipalPage();

                   principalPage.Detail = new NavigationPage(new RelatorioPage());
                   principalPage.IsPresented = false;

                   MainPage = principalPage;
               });


        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        internal static void LoadGlobalVariables()
        {
            // Carregando a lista de Perfil para acesso Global
            // Model.Global.Perfis = new PerfilBusiness().GetList();

            // Carregando o Investidor Logado
            //  Model.Global.Investidor = new InvestidorBusiness().GetInvestidorLogged();

        }


        internal static void MensagemAlerta(string texto)
        {
            App.Current.MainPage.DisplayAlert("Título", texto, "Ok");
        }




    }
}