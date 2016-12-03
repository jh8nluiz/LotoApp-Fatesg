using System;
using System.Collections.Generic;
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
using Loto.Entity;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Loto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Jogo> listJogos = new List<Jogo>();

        public MainPage()
        {
            this.InitializeComponent();

            listJogos.Add(new Entity.Jogo { TipoJogo = "MEGA SENA", Resultado = "01 - 02 - 03 - 04 - 05 - 06" });
            listJogos.Add(new Entity.Jogo { TipoJogo = "QUINA", Resultado = "01 - 02 - 03 - 04 - 05" });

            JogosList.ItemsSource = listJogos;
        }

        private void btnLotoFacil_Click(object sender, RoutedEventArgs e)
        {
            UIJogo lotoFacil = new UIJogo();
            
        }
    }
}
