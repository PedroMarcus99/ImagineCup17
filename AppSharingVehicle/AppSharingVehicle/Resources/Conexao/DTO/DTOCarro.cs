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
    public class DTOCarro
    {
        public string Renavam { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }   
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public string Quilometragem { get; set; }
    }
}