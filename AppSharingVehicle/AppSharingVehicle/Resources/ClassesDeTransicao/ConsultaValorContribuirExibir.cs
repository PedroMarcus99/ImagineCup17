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

namespace AppSharingVehicle.Resources
{ [Activity (Label = "Consulta de Valores")]
    public class ConsultaValorContribuirExibir : Activity
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
    }
}