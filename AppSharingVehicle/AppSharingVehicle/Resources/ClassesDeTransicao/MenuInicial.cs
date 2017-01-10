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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);
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
        MainActivity UsaBotao = new MainActivity(); 

        public void InstanciaBotoes(){
            FindViewById<Button>(Resource.Id.BtnCadastrarGrupoExibir).Click += UsaBotao.ExibeTelaCadastroDeGrupo;
            FindViewById<Button>(Resource.Id.BtnCadastrarVeiculoExibir).Click += UsaBotao.ExibeTelaCadastroDeCarro;
            FindViewById<Button>(Resource.Id.BtnCadastroVistoriaExibir).Click += UsaBotao.ExibeTelaCadastroDeVistoria;
            FindViewById<Button>(Resource.Id.BtnPesquisarDadosExibir).Click += UsaBotao.ExibeTelaPesquisaDeDados;
            FindViewById<Button>(Resource.Id.BtnPesquisaVeiculoExibir).Click += UsaBotao.ExibeTelaPesquisaDeVeiculo;
            FindViewById<Button>(Resource.Id.BtnRodizioExibir).Click += UsaBotao.ExibeTelaPesquisaDeRodizio;
            FindViewById<Button>(Resource.Id.BtnValoresExibir).Click += UsaBotao.ExibeTelaConsultaValorContribuir;
            FindViewById<Button>(Resource.Id.CadastroGastoExibir).Click += UsaBotao.ExibeTelaCadastroDeGasto;
            FindViewById<Button>(Resource.Id.BtnCompraCombustivelExibir).Click += UsaBotao.ExibeTelaCadastroCompraCombustivel;
            FindViewById<Button>(Resource.Id.BtnOficinas).Click += UsaBotao.ExibeTelaMapaDeOficinas;
            FindViewById<Button>(Resource.Id.BtnPesquisarDadosExibir).Click += UsaBotao.ExibeTelaPesquisaDeDados;
        }
    }
}