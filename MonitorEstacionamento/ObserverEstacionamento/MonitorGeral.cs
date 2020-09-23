using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MonitorEstacionamento.ObserverEstacionamento
{
    public class MonitorGeral : EstacionamentoObserverAb
    {
        public List<EstacionamentoAb> Estacionamentos { get; set; }

        public MonitorGeral()
        {
            Estacionamentos = new List<EstacionamentoAb>();
        }

        public override void Atualizar()
        {            
            Debug.WriteLine("========= Monitor GERAL ===========");
            foreach (EstacionamentoAb est in Estacionamentos)
            {
                Debug.WriteLine("===================================");
                Debug.WriteLine(est);
                Debug.WriteLine("===================================");
            }
        }
    }
}
