using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppSharingVehicle.Resources.ClassesDeTransicao;
using AppSharingVehicle.Resources; 

namespace AppSharingVehicle.Resources.ClassesDeTransicao
{ [Activity (Label = "Menu Inicial")]

    public class MenuInicial : Activity
    {
        //Instancia a tela Inicial, MainActivity no caso. 
        MainActivity UsaBotao = new MainActivity();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MenuInicial);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);

            //M�todo para ativa��o ddos bot�es da Activity. 
            InstanciaBotoes(); 
        }

        public override bool OnContextItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnContextItemSelected(item);
            }
        }        

        public void InstanciaBotoes()
        {
            //Estes m�todos dos bot�es acessam cada tela de acordo com o toque na tela. 
            FindViewById<Button>(Resource.Id.BtnCadastrarGrupoExibir).Click += ExibeTelaCadastroDeGrupo;
            FindViewById<Button>(Resource.Id.BtnCadastrarVeiculoExibir).Click += ExibeTelaCadastroDeCarro;
            FindViewById<Button>(Resource.Id.BtnCadastroVistoriaExibir).Click += ExibeTelaCadastroDeVistoria;
            FindViewById<Button>(Resource.Id.BtnPesquisarDadosExibir).Click += ExibeTelaPesquisaDeDados;
            FindViewById<Button>(Resource.Id.BtnPesquisaVeiculoExibir).Click +=ExibeTelaPesquisaDeVeiculo;
            FindViewById<Button>(Resource.Id.BtnRodizioExibir).Click += ExibeTelaPesquisaDeRodizio;
            FindViewById<Button>(Resource.Id.BtnValoresExibir).Click += ExibeTelaConsultaValorContribuir;
            FindViewById<Button>(Resource.Id.CadastroGastoExibir).Click += ExibeTelaCadastroDeGasto;
            FindViewById<Button>(Resource.Id.BtnCompraCombustivelExibir).Click += ExibeTelaCadastroCompraCombustivel;
            FindViewById<Button>(Resource.Id.BtnOficinas).Click += ExibeTelaMapaDeOficinas;
            FindViewById<Button>(Resource.Id.BtnPesquisarDadosExibir).Click += ExibeTelaPesquisaDeDados;
        }


        //M�todo que instancia a tela de cadastro de carro. 
         void ExibeTelaCadastroDeCarro(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCarroExibir));
        }

        //M�todo que instancia a tela de Cadastro de Compra de Combust�vel. 
        void ExibeTelaCadastroCompraCombustivel(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCompraCombustivelExibir1));
        }

        //M�todo que instancia a tela de Cadastro de Gasto. 
         void ExibeTelaCadastroDeGasto(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGastoExibir));
        }

        //M�todo que instancia a tela de Cadastro de Grupo. 
         void ExibeTelaCadastroDeGrupo(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGrupoExibir));
        }

        //M�todo que instancia a tela de Cadastro de Motorista. 
         void ExibeTelaCadastroDeMotorista(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroMotoristaExibir));
        }

        //M�todo que instancia a tela de Cadastro de Cistoria. 
         void ExibeTelaCadastroDeVistoria(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroVistoriaExibir));
        }

        //M�todo que instancia a tela de Consulta Valor a Contribuir.
         void ExibeTelaConsultaValorContribuir(object sender, EventArgs e)
        {
            StartActivity(typeof(ConsultaValorContribuirExibir));
        }

        //M�todo que instancia a tela de Mapa de Oficinas.
         void ExibeTelaMapaDeOficinas(object sender, EventArgs e)
        {
            StartActivity(typeof(MapaOficinaExibir));
        }

        //M�todo que instancia a tela de Pesquisa de Dados. 
         void ExibeTelaPesquisaDeDados(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaDadosExibir));
        }

        //M�todo que instancia a tela de Pesquisa de Rodizio. 
         void ExibeTelaPesquisaDeRodizio(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaRodizioExibir));
        }

        //M�todo que instancia a tela de Pesquisa de Veiculo.
         void ExibeTelaPesquisaDeVeiculo(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaVeiculoExibir));
        }


    }
}