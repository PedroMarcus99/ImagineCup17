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
    public class DTOAgenda
    {
        public string DiaAgendamento { get; set; }
        public string HorarioAgendamento { get; set; }
        public string IdCarroAgendamento { get; set; }
        public string IdMotoristaAgendamento { get; set; }
    }
}