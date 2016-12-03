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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Loto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UIJogo : Page
    {        
        public UIJogo()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            var tipoJogo = (EnumTipoJogo.TipoJogo)e.Parameter;
           
            if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.LOTOFACIL))
            {
                lblNomeJogo.Text = "Lotofácil";
            } else
            {
                if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.DUPLASENA))
                {
                    lblNomeJogo.Text = "Duplasena";
                } else
                {
                    if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.LOTOMANIA))
                    {
                        lblNomeJogo.Text = "Lotomania";
                    } else
                    {
                        if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.MEGASENA))
                        {
                            lblNomeJogo.Text = "Megasena";
                        } else
                        {
                            if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.QUINA))
                            {
                                lblNomeJogo.Text = "Quina";
                            } else
                            {
                                lblNomeJogo.Text = "Timemania";
                            }
                        }
                    }
                }
            }
            
           

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
