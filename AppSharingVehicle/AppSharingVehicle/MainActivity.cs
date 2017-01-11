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
using AppSharingVehicle.Resources.ClassesDeTransicao; 



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
            SetContentView (Resource.Layout.Main);

            //os botões que instanciam uma nova tela ficam aqui.. 
            FindViewById<Button>(Resource.Id.BtnLogin).Click += ExibeTelaLogin;
            FindViewById<Button>(Resource.Id.BtnCadastro).Click += ExibeTelaCadastroDeUsuario;
           

        }
        //Método que instancia a tela de login. 
        public void ExibeTelaLogin(object sender,EventArgs e )
        {
            StartActivity(typeof(TelaLogin));
        }

        //Método que instancia a tela de Cadastro de usuário. 
        public void ExibeTelaCadastroDeUsuario(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroUsuarioExibir)); 
        }

        //Método que instancia a tela de cadastro de carro. 
        public void ExibeTelaCadastroDeCarro(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCarroExibir));
        }

        //Método que instancia a tela de Cadastro de Compra de Combustível. 
        public void ExibeTelaCadastroCompraCombustivel(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCompraCombustivelExibir1)); 
        }

        //Método que instancia a tela de Cadastro de Gasto. 
        public void ExibeTelaCadastroDeGasto(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGastoExibir));
        }

        //Método que instancia a tela de Cadastro de Grupo. 
        public void ExibeTelaCadastroDeGrupo(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGrupoExibir));
        }

        //Método que instancia a tela de Cadastro de Motorista. 
        public void ExibeTelaCadastroDeMotorista(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroMotoristaExibir));
        }

        //Método que instancia a tela de Cadastro de Cistoria. 
        public void ExibeTelaCadastroDeVistoria(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroVistoriaExibir)); 
        }

        //Método que instancia a tela de Consulta Valor a Contribuir.
        public void ExibeTelaConsultaValorContribuir(object sender, EventArgs e)
        {
            StartActivity(typeof(ConsultaValorContribuirExibir));
        }

        //Método que instancia a tela de Mapa de Oficinas.
        public void ExibeTelaMapaDeOficinas(object sender, EventArgs e)
        {
            StartActivity(typeof(MapaOficinaExibir));
        }

        //Método que instancia a tela de Pesquisa de Dados. 
        public void ExibeTelaPesquisaDeDados(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaDadosExibir)); 
        }

        //Método que instancia a tela de Pesquisa de Rodizio. 
        public void ExibeTelaPesquisaDeRodizio(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaRodizioExibir));
        }

        //Método que instancia a tela de Pesquisa de Veiculo.
        public void ExibeTelaPesquisaDeVeiculo(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaVeiculoExibir)); 
        }

       

    }
}

