using MonitorEstacionamento.ObserverEstacionamento;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace MonitorEstacionamento
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Estacionamento EstacionamentoSuperior { get; set; }
        public Estacionamento EstacionamentoInferior { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            EstacionamentoSuperior = new Estacionamento(80, 50, 300);
            EstacionamentoInferior = new Estacionamento(40, 30, 200);
            Monitor mSup = new Monitor { Estacionamento = EstacionamentoSuperior, Descricao = "Monitor da Entrada Superior" };
            Monitor mInf = new Monitor { Estacionamento = EstacionamentoInferior, Descricao = "Monitor da Entrada Inferior" };

            MonitorGeral mGeral = new MonitorGeral();
            mGeral.Estacionamentos.Add(EstacionamentoSuperior);
            mGeral.Estacionamentos.Add(EstacionamentoInferior);

            EstacionamentoSuperior.Anexar(mSup);
            EstacionamentoInferior.Anexar(mInf);
            EstacionamentoSuperior.Anexar(mGeral);
            EstacionamentoInferior.Anexar(mGeral);

            Debug.WriteLine("===========================================================");
            Debug.WriteLine("Iniciando os Estacionamentos");
            Debug.WriteLine("Estacionamento Superior:");
            Debug.WriteLine(EstacionamentoSuperior);
            Debug.WriteLine("Estacionamento Inferior:");
            Debug.WriteLine(EstacionamentoInferior);
            Debug.WriteLine("===========================================================");
        }

        private void BtnNovoVeiculoReg_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoSuperior.ChegarVeiculo(TipoVaga.Regular);
        }

        private void BtnNovoVeiculoPCD_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoSuperior.ChegarVeiculo(TipoVaga.PCD);
        }

        private void BtnNovaMoto_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoSuperior.ChegarVeiculo(TipoVaga.Moto);
        }

        private void BtnSaiuVeiculoReg_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoSuperior.SairVeiculo(TipoVaga.Regular);
        }

        private void BtnSaiuVeiculoPCD_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoSuperior.SairVeiculo(TipoVaga.PCD);
        }

        private void BtnSaiuMoto_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoSuperior.SairVeiculo(TipoVaga.Moto);

        }

        private void BtnNovoVeiculoRegInf_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoInferior.ChegarVeiculo(TipoVaga.Regular);
        }

        private void BtnNovoVeiculoPCDInf_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoInferior.ChegarVeiculo(TipoVaga.PCD);
        }

        private void BtnNovaMotoInf_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoInferior.ChegarVeiculo(TipoVaga.Moto);

        }

        private void BtnSaiuVeiculoRegInf_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoInferior.SairVeiculo(TipoVaga.Regular);
        }

        private void BtnSaiuVeiculoPCDInf_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoInferior.SairVeiculo(TipoVaga.PCD);
        }

        private void BtnSaiuMotoInf_Click(object sender, RoutedEventArgs e)
        {
            EstacionamentoInferior.SairVeiculo(TipoVaga.Moto);
        }
    }
}
