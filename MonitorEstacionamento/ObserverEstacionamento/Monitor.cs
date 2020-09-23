using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorEstacionamento.ObserverEstacionamento
{
    public class Monitor : EstacionamentoObserverAb
    {
        public EstacionamentoAb Estacionamento { get; set; }
        public string Descricao { get; set; }
        public override void Atualizar()
        {
            Debug.WriteLine("======================================");
            Debug.WriteLine($"Monitor {Descricao}:");
            Debug.WriteLine("======================================");
            Debug.WriteLine(Estacionamento);
            Debug.WriteLine("======================================");
        }
    }
}
