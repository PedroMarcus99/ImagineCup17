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

namespace AppSharingVehicle.Resources.Conexao.DTO
{
    public class DTOAbastecimento
    {
        public string DataAbastecimento { get; set; }
        public string TipoCombustivel { get; set; }
        public string ValorAbastecimento { get; set; }
        public string LitrosAbastecimento { get; set; }
        public string IdCarroAbastecimento { get; set; }
    }
}