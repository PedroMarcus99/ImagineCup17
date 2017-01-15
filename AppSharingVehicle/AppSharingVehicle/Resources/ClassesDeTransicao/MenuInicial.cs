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
        MainActivity UsaBotao = new MainActivity();
        /// <summary>
        /// Instancia a tela Inicial, Menu inicial no caso. 
        /// </summary>
        /// <param name="bundle"></param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MenuInicial);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);

            //Método para ativação ddos botões da Activity. 
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

        /// <summary>
        /// Estes métodos dos botões acessam cada tela de acordo com o toque na tela. 
        /// </summary>
        public void InstanciaBotoes()
        {
            
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

        
        /// <summary>
        /// Método que instancia a tela de cadastro de carro. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaCadastroDeCarro(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCarroExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Cadastro de Compra de Combustível. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaCadastroCompraCombustivel(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroCompraCombustivelExibir1));
        }

        
        /// <summary>
        /// Método que instancia a tela de Cadastro de Gasto. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaCadastroDeGasto(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGastoExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Cadastro de Grupo. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaCadastroDeGrupo(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroGrupoExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Cadastro de Motorista. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaCadastroDeMotorista(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroMotoristaExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Cadastro de Cistoria. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaCadastroDeVistoria(object sender, EventArgs e)
        {
            StartActivity(typeof(CadastroVistoriaExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Consulta Valor a Contribuir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaConsultaValorContribuir(object sender, EventArgs e)
        {
            StartActivity(typeof(ConsultaValorContribuirExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Mapa de Oficinas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaMapaDeOficinas(object sender, EventArgs e)
        {
            StartActivity(typeof(MapaOficinaExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Pesquisa de Dados. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaPesquisaDeDados(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaDadosExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Pesquisa de Rodizio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaPesquisaDeRodizio(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaRodizioExibir));
        }

        
        /// <summary>
        /// Método que instancia a tela de Pesquisa de Veiculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeTelaPesquisaDeVeiculo(object sender, EventArgs e)
        {
            StartActivity(typeof(PesquisaVeiculoExibir));
        }


    }
}