using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class FinestraPrincipale : Window
    {
        //INIZIALIZZAZIONE
        public static List<string> TESTI_PREDEFINITI = new List<string>();
        public static Dictionary<Button, string> CHAT_URL = new Dictionary<Button, string>();
        private Connessione C = new Connessione();

        //InizializzazioneFinestra
        public FinestraPrincipale()
        {
            InitializeComponent();
            C.VaiUrl("https://deepai.org/chat");
            TESTI_PREDEFINITI.Add("Nuova Chat");
            TESTI_PREDEFINITI.Add(this.InputTestuale.Text);
        }
    
    //FUNZIONI ELEMENTARI
    private void CreaChat (object emettitore, RoutedEventArgs evento)
        {
            
            TextBox textBox = new TextBox { Name = "NuovaChat", Text = TESTI_PREDEFINITI.ElementAt<string>(0), BorderThickness = new Thickness(0) };
            textBox.GotFocus += EliminaTestoClick;
            textBox.LostFocus += AggiungiTestoClick;
            Button pulsanteAggiunto = new Button { Name = "NuovaChatPulsante", Content = textBox, FontSize = 15, FontFamily = new FontFamily("Futura"), Foreground = Brushes.DimGray, Height = 40, Background = Brushes.White, BorderThickness = new Thickness(0) };
            this.PannelloChat.Children.Add(pulsanteAggiunto);
            
            
        }
    private void EliminaTestoClick(object emettitore, RoutedEventArgs evento)
        {
            
            TextBox textBox = emettitore as TextBox;
            string testoOriginario = textBox.Text;
            
            if (textBox.IsKeyboardFocused && TESTI_PREDEFINITI.Contains(textBox.Text))
            {
                textBox.Text = "";
            }
        }
        private void CambiaColoreTesto (object emettitore, Brush B)
        {
            TextBox textBox = emettitore as TextBox;
            textBox.Foreground = B;
        }

        private void AggiungiTestoClick(object emettitore, RoutedEventArgs evento) {
            TextBox textBox = emettitore as TextBox;
            if (textBox.Text == "")
            {
                if (textBox.Name == "NuovaChat")
                {
                    textBox.Text = TESTI_PREDEFINITI.ElementAt<string>(0);
                }
                else if (textBox.Name == "InputTestuale")
                {
                    textBox.Text = TESTI_PREDEFINITI.ElementAt<string>(1);
                }
            }
        }
        // FUNZIONI OGGETTI
        private void ReazioneClickInputTestuale(object emettitore, RoutedEventArgs evento)
        {
            EliminaTestoClick(emettitore, evento);
            CambiaColoreTesto(emettitore, Brushes.Black);
        }
        private void ReazioneDeselezioneInputTestuale(object emettitore, RoutedEventArgs evento)
        {
            AggiungiTestoClick(emettitore, evento);
            CambiaColoreTesto(emettitore, Brushes.DimGray);
        }
    }
}
