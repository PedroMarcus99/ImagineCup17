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
        /// <summary>
        /// Instancia a tela de Login. 
        /// </summary>
        /// <param name="bundle"></param>
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

        
        /// <summary>
        /// M�todo que instancia a tela de Menu Inicial ap�s o Login ser realizado..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ExibeMenuInicial(object sender, EventArgs e)
        {
            StartActivity(typeof(MenuInicial));
        }

        
        /// <summary>
        /// M�todo que acessa a tela Inicial ao tocar no Bot�o. 
        /// </summary>
        public void UtilizaBotao()
        {
            FindViewById<Button>(Resource.Id.BtnLogar).Click += ExibeMenuInicial;
        }
       
        
    }
}