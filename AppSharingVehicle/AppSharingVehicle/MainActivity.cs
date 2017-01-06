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
namespace AppSharingVehicle
{
    [Activity(Label = "Sharing Vehicle", MainLauncher = true, Icon = "@drawable/sharing48")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            //os botões que instanciam uma nova tela ficam aqui.. 
            FindViewById<Button>(Resource.Id.BtnLogin).Click += ExibeTelaLogin;
        }

        void ExibeTelaLogin(object sender,EventArgs e )
        {
            StartActivity(typeof(TelaLogin));
        }
    }
}

