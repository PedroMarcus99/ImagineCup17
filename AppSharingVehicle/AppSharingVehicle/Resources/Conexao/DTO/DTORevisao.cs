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
    public class DTORevisao
    {
        public string TipoRevisao { get; set; }
        public string NomeOficina { get; set; }
        public string DataEntradaRevisao { get; set; }
        public string DataSaidaRevisao { get; set; }
        public string HoraEntradaRevisao { get; set; }
        public string HoraSaidaRevisao { get; set; }
        public string NomeItemRevisao { get; set; }
        public string PrecoRevisao { get; set; }
        public string QuantidadeItemRevisao { get; set; }
        public string IdCarroRevisao { get; set; }
    }
}