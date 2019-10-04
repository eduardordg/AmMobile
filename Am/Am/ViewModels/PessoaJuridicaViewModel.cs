using Am.Layers.Business;
using Am.Layers.Services;
using Am.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Am.ViewModels
{
    public class PessoaJuridicaViewModel : INotifyPropertyChanged
    {

        public ICommand PesquisarClickedCommand { get; private set; }

        public PessoaJuridicaViewModel()
        {
            PesquisarClickedCommand = new Command(() => {


                var pessoaJuridicaBusiness = new PessoaJuridicaBusiness();  //Instanciando business para acessar a service e pegar dados da api
                var service = pessoaJuridicaBusiness.getService(); //atribuiu o objeto service a uma variavel para fazer as chamadas das API dentros dos IF conforme resultados dos Switchs
                var relatorio = new RelatorioViewModel(); // instancia relatorio para envio das informações para a tela

                //validação CNPJ NULO
                if (String.IsNullOrEmpty(cnpj) == true)
                {

                    DependencyService.Get<IMessage>().ShortAlert("Por favor digite seu CNPJ");
                }

                else
                {
                    //Validação todos Switchs Nulos
                    if (infoseg == false && arisp == false && cadesp == false && jucesp == false && arpensp == false && vec == false && tre == false && caged == false && censec == false && infocrim == false)
                    {
                        DependencyService.Get<IMessage>().ShortAlert("Por favor selecione ao menos uma base de dados para consulta");
                    }

                    else
                    {

                        if (infoseg == true)
                        {

                            string dadosEncontrados; //variavel para receber dados
                            dadosEncontrados = service.getInfoseg(cnpj); //envio dos dados que a instancia da service conseguiu
                            relatorio.Resultado += dadosEncontrados; // soma-se ao valor que já há no resultado
                            GlobalViewModel.Relatorio = relatorio;// manda os dados para a global, fazendo a RelatorioViewModel enxergar

                            //mesma coisa acontece nos 9 restantes itens ifs abaixo
                        }

                        if (arisp == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getArisp(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (cadesp == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getCadesp(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (jucesp == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getJucesp(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (arpensp == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getArpensp(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (vec == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getVec(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (tre == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getTre(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (caged == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getCaged(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (censec == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getCensec(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        if (infocrim == true)
                        {
                            string dadosEncontrados;
                            dadosEncontrados = service.getInfocrim(cnpj);
                            relatorio.Resultado += dadosEncontrados;
                            GlobalViewModel.Relatorio = relatorio;
                        }

                        MessagingCenter.Send<PessoaJuridicaViewModel>(this, "RelatorioPageAbrir");

                    }
                }
            });

        }

        //Declaração atributos
        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set
            {
                if (cnpj != value)
                {
                    cnpj = value;
                    NotifyPropertyChanged();
                }
            }
        }

        //Declaração atributos que vão receber o valor do Switch das base de dados
        

        private bool infoseg;
        public bool Infoseg
        {
            get { return infoseg; }
            set
            {
                if (infoseg != value)
                {
                    infoseg = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private bool arisp;
        public bool Arisp
        {
            get { return arisp; }
            set
            {

                arisp = value;
                NotifyPropertyChanged();

            }
        }

        private bool cadesp;
        public bool Cadesp
        {
            get { return cadesp; }
            set
            {
                if (cadesp != value)
                {
                    cadesp = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool jucesp;
        public bool Jucesp
        {
            get { return jucesp; }
            set
            {
                if (jucesp != value)
                {
                    jucesp = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private bool arpensp;
        public bool Arpensp
        {
            get { return arpensp; }
            set
            {
                if (arpensp != value)
                {
                    arpensp = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool vec;
        public bool Vec
        {
            get { return vec; }
            set
            {
                if (vec != value)
                {
                    vec = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool tre;
        public bool Tre
        {
            get { return tre; }
            set
            {
                if (tre != value)
                {
                    tre = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool caged;
        public bool Caged
        {
            get { return caged; }
            set
            {
                if (caged != value)
                {
                    caged = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool censec;
        public bool Censec
        {
            get { return censec; }
            set
            {
                if (censec != value)
                {
                    censec = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool infocrim;
        public bool Infocrim
        {
            get { return infocrim; }
            set
            {
                if (infocrim != value)
                {
                    infocrim = value;
                    NotifyPropertyChanged();
                }
            }
        }






        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
