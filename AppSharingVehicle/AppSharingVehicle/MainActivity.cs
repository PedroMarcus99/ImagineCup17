using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System; 

namespace AppSharingVehicle
{
    [Activity(Label = "Sharing Vehicle", MainLauncher = true, Icon = "@drawable/sharing48")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //os botões que instanciam uma nova tela ficam aqui.. 
            FindViewById<Button>(Resource.Id.BtnLogin).Click += ExibeTelaLogin; 
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }

        void ExibeTelaLogin(object sender,EventArgs e )
        {
            StartActivity(typeof(TelaLogin));
        }
    }
}

