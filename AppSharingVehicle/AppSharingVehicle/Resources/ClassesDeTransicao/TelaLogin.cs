using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml; 
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppSharingVehicle.Resources;
using AppSharingVehicle.Resources.ClassesDeTransicao; 

namespace AppSharingVehicle
{ [Activity (Label = "Login")]
    public class TelaLogin : Activity
    {
        MainActivity UsaBotao = new MainActivity();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);

            //M�todo que utiliza bot�o da classe.. 
            UtilizaBotao(); 
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

        //M�todo que instancia a tela de Menu Inicial ap�s o Login ser realizado..
        void ExibeMenuInicial(object sender, EventArgs e)
        {
            StartActivity(typeof(MenuInicial));
        }

        //M�todo que acessa a tela Inicial ao tocar no Bot�o. 
        public void UtilizaBotao()
        {
            FindViewById<Button>(Resource.Id.BtnLogar).Click += ExibeMenuInicial;
        }
       
        
    }
}