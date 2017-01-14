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
    public class DTOMotorista
    {
        public string NomeMotorista { get; set; }
        public string CNHMotorista { get; set; }
        public string CPFMotorista { get; set; }
        public string DataNascimentoMotorista { get; set; }
        public string dataVencimentoCNH { get; set; }
    }
}