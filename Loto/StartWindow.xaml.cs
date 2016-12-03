using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
        private JsonWebClient client = new JsonWebClient();
        private ObservableCollection<Entity.Jogo> listJogos = new ObservableCollection<Entity.Jogo>();
        private string token = "WxZdRtutLf8bTcE";

        public MainPage()
        {
            this.InitializeComponent();

            buscarJogos();
            
        }

        private async void buscarJogos()
        {
            Entity.Jogo lotoFacil = await buscarJogo("lotofacil");
            Entity.Jogo megaSena = await buscarJogo("megasena");
            Entity.Jogo lotoMania = await buscarJogo("lotomania");
            Entity.Jogo quina = await buscarJogo("quina");
            Entity.Jogo timeMania = await buscarJogo("timemania");
            Entity.Jogo duplaSena = await buscarJogo("duplasena");
        }

        private void btnLotoMania_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UIJogo), EnumTipoJogo.TipoJogo.LOTOMANIA);
        }

        private void btnDuplaSena_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UIJogo), EnumTipoJogo.TipoJogo.DUPLASENA);
        }

        private void btnQuina_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UIJogo), EnumTipoJogo.TipoJogo.QUINA);
        }

        private void btnTimeMania_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UIJogo), EnumTipoJogo.TipoJogo.TIMEMANIA);            
        }

        private async Task<Entity.Jogo> buscarJogo(string tipoJogo)
        {
            string url = "http://confiraloterias.com.br/api/json/?loteria=" + tipoJogo + "&token=" + token;
            Entity.Jogo jogo = await client.DoRequestJsonAsync<Entity.Jogo>(url);
            jogo.Resultado = tratarResultado(tipoJogo, jogo.concurso);
            jogo.TipoJogo = tipoJogo.ToUpper();

            return jogo;
        }        

        private string tratarResultado(string tipoJogo, Entity.Concurso concurso)
        {

            if (tipoJogo == "duplasena")
            {
                return concurso.dezenas_1.Aggregate((current, next) => current + " - " + next);
            }else
            {
                return concurso.dezenas.Aggregate((current, next) => current + " - " + next);
            }


        }

        
    }
}
