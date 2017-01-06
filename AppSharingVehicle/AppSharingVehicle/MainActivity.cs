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
            SetContentView (Resource.Layout.Main);

            //os botões que instanciam uma nova tela ficam aqui.. 
            FindViewById<Button>(Resource.Id.BtnLogin).Click += ExibeTelaLogin;
            FindViewById<Button>(Resource.Id.BtnCadastro).Click += ExibeTelaCadastroDeUsuario; 
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
    }
}

