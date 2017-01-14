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
    public class DTOGasto
    {
        public string TipoGasto { get; set; }
        public string NumeroParcelaGasto { get; set; }
        public string ValorParcelaGasto { get; set; }
    }
}