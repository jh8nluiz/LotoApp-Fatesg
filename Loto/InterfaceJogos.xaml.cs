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

        private App1.Model Conexao;
        private string IdJogo;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Conexao = new App1.Model();
           
            var tipoJogo = (EnumTipoJogo.TipoJogo)e.Parameter;

            if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.LOTOFACIL))
            {
                IdJogo = "1";
                lblNomeJogo.Text = "Lotofácil";
            }
            else
            {
                if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.DUPLASENA))
                {
                    IdJogo = "2";
                    lblNomeJogo.Text = "Duplasena";
                }
                else
                {
                    if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.LOTOMANIA))
                    {
                        IdJogo = "3";
                        lblNomeJogo.Text = "Lotomania";
                    }
                    else
                    {
                        if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.MEGASENA))
                        {
                            IdJogo = "4";
                            lblNomeJogo.Text = "Megasena";
                        }
                        else
                        {
                            if (tipoJogo.Equals(EnumTipoJogo.TipoJogo.QUINA))
                            {
                                IdJogo = "5";
                                lblNomeJogo.Text = "Quina";
                            }
                            else
                            {
                                IdJogo = "6";
                                lblNomeJogo.Text = "Timemania";
                            }
                        }
                    }
                }
            }

            txtJogo.Text = Conexao.ObterJogo(IdJogo);
        }            

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void btnJogar_Click(object sender, RoutedEventArgs e)
        {
            Conexao.SalvarJogo(IdJogo, txtJogo.Text);
        }
    }
}
