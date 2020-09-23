using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.VoiceCommands;

namespace MonitorEstacionamento.ObserverEstacionamento
{
    /// <summary>
    /// Subject
    /// </summary>
    public abstract class EstacionamentoAb
    {
        protected List<EstacionamentoObserverAb> monitores = new List<EstacionamentoObserverAb>();
        public int QuantVagasRegulares { get; set; }
        public int QuantVagasPCDs { get; set; }
        public int QuantVagasMotos { get; set; }

        public void Anexar(EstacionamentoObserverAb o)
        {
            monitores.Add(o);
        }


        public void Notificar()
        {
            // Notificar todos os observadores
            foreach (EstacionamentoObserverAb o in monitores)
            {
                o.Atualizar();
            }
        }


        public override string ToString()
        {
            string dados = $"Vagas Regulares: {QuantVagasRegulares}\nVagas PCD: {QuantVagasPCDs}\nVagas Motos: {QuantVagasMotos}";
            return dados;
        }
    }
}
