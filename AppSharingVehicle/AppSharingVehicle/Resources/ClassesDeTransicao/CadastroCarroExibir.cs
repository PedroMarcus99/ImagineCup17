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
{ [Activity (Label = "Cadastro de Carro" )]
    public class CadastroCarroExibir : Activity
    {
        /// <summary>
        /// Instancia a tela de Cadastro de ve�culo. 
        /// </summary>
        /// <param name="bundle"></param>
       protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CadastroCarro);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true); 
        }

        public override bool OnContextItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return false;
                default:
                    return base.OnContextItemSelected(item);
            }            
        }
    }
}