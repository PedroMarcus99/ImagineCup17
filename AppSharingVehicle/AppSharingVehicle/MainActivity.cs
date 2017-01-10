using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.Locations;
using AppSharingVehicle.Resources; 



namespace AppSharingVehicle
{
    [Activity(Label = "Sharing Vehicle", MainLauncher = true, Icon = "@drawable/sharing48")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // Instancia a tela para a primeira exibição do Software. 
            SetContentView (Resource.Layout.MenuInicial);

            //os botões que instanciam uma nova tela ficam aqui.. 
            FindViewById<Button>(Resource.Id.BtnLogin).Click += ExibeTelaLogin;
            FindViewById<Button>(Resource.Id.BtnCadastro).Click += ExibeTelaCadastroDeUsuario;
            FindViewById<Button>(Resource.Id.BtnCadastrarGrupoExibir).Click += ExibeTelaCadastroDeGrupo;
            FindViewById<Button>(Resource.Id.BtnCadastrarVeiculoExibir).Click += ExibeTelaCadastroDeCarro;
            FindViewById<Button>(Resource.Id.BtnCadastroVistoriaExibir).Click += ExibeTelaCadastroDeVistoria;
            FindViewById<Button>(Resource.Id.BtnPesquisarDadosExibir).Click += ExibeTelaPesquisaDeDados;
            FindViewById<Button>(Resource.Id.BtnPesquisaVeiculoExibir).Click += ExibeTelaPesquisaDeVeiculo;
            FindViewById<Button>(Resource.Id.BtnRodizioExibir).Click += ExibeTelaPesquisaDeRodizio;
            FindViewById<Button>(Resource.Id.BtnValoresExibir).Click += ExibeTelaConsultaValorContribuir;
            FindViewById<Button>(Resource.Id.CadastroGastoExibir).Click += ExibeTelaCadastroDeGasto;
            FindViewById<Button>(Resource.Id.BtnCompraCombustivelExibir).Click += ExibeTelaCadastroCompraCombustivel;
            FindViewById<Button>(Resource.Id.BtnOficinas).Click += ExibeTelaMapaDeOficinas;
            FindViewById<Button>(Resource.Id.BtnPesquisarDadosExibir).Click += ExibeTelaPesquisaDeDados; 

        }
        //Método que instancia a tela de login. 
        void ExibeTelaLogin(object sender,EventArgs e )
        {
            StartActivity(typeof(TelaLogin));
        }

        //Método que instancia a tela de Cadastro de usuário. 
        void ExibeTelaCadastroDeUsuario(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroUsuarioExibir)); 
        }

        //Método que instancia a tela de cadastro de carro. 
        void ExibeTelaCadastroDeCarro(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCarroExibir));
        }

        //Método que instancia a tela de Cadastro de Compra de Combustível. 
        void ExibeTelaCadastroCompraCombustivel(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCompraCombustivelExibir1)); 
        }

        //Método que instancia a tela de Cadastro de Gasto. 
        void ExibeTelaCadastroDeGasto(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGastoExibir));
        }

        //Método que instancia a tela de Cadastro de Grupo. 
        void ExibeTelaCadastroDeGrupo(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGrupoExibir));
        }

        //Método que instancia a tela de Cadastro de Motorista. 
        void ExibeTelaCadastroDeMotorista(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroMotoristaExibir));
        }

        //Método que instancia a tela de Cadastro de Cistoria. 
        void ExibeTelaCadastroDeVistoria(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroVistoriaExibir)); 
        }

        //Método que instancia a tela de Consulta Valor a Contribuir.
        void ExibeTelaConsultaValorContribuir(object sender, EventArgs e)
        {
            StartActivity(typeof(ConsultaValorContribuirExibir));
        }

        //Método que instancia a tela de Mapa de Oficinas.
        void ExibeTelaMapaDeOficinas(object sender, EventArgs e)
        {
            StartActivity(typeof(MapaOficinaExibir));
        }

        //Método que instancia a tela de Pesquisa de Dados. 
        void ExibeTelaPesquisaDeDados(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaDadosExibir)); 
        }

        //Método que instancia a tela de Pesquisa de Rodizio. 
        void ExibeTelaPesquisaDeRodizio(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaRodizioExibir));
        }

        //Método que instancia a tela de Pesquisa de Veiculo.
        void ExibeTelaPesquisaDeVeiculo(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaVeiculoExibir)); 
        }

        //Método que instancia a tela de Menu Inicial após o Login ser realizado..
         

    }
}

