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
            FindViewById<Button>(Resource.Id.BtnLogar).Click += UsaBotao.ExibeMenuInicial;
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
        
       
       
        
    }
}