using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorEstacionamento.ObserverEstacionamento
{
    public enum TipoVaga
    {
        Regular,
        PCD,
        Moto
    }

    public class Estacionamento : EstacionamentoAb
    {
        public Estacionamento(int qtMotos, int qtPCD, int qtReg)
        {
            QuantVagasMotos = qtMotos;
            QuantVagasPCDs = qtPCD;
            QuantVagasRegulares = qtReg;
        }

        public void ChegarVeiculo(TipoVaga tv)
        {
            switch (tv)
            {
                case TipoVaga.Moto:
                    QuantVagasMotos--;
                    break;
                case TipoVaga.PCD:
                    QuantVagasPCDs--;
                    break;
                default:
                    QuantVagasRegulares--;
                    break;
            }
            Notificar();
        }

        public void SairVeiculo(TipoVaga tv)
        {
            switch (tv)
            {
                case TipoVaga.Moto:
                    QuantVagasMotos++;
                    break;
                case TipoVaga.PCD:
                    QuantVagasPCDs++;
                    break;
                default:
                    QuantVagasRegulares++;
                    break;
            }
            Notificar();
        }

        public override string ToString()
        {
            string dados = $"Vagas Regulares: {QuantVagasRegulares}\nVagas PCD: {QuantVagasPCDs}\nVagas Motos: {QuantVagasMotos}";
            return dados;
        }
    }
}
