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
using Microsoft.Speech.Recognition;
using Microsoft.Speech.Synthesis;
using System.Globalization;

namespace Kebab_Vending_Machine
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SpeechSynthesizer ss = new SpeechSynthesizer();
        public static SpeechRecognitionEngine sre;
        public static CultureInfo ci = new CultureInfo("pl-PL");
        public static Grammar grammar = new Grammar(".\\Grammar.xml", "rootRule");
        public MainWindow()
        {
            InitializeComponent();
            ss.SetOutputToDefaultAudioDevice();
            sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();
            MainWindow.grammar.Enabled = true;
            MainWindow.sre.LoadGrammar(MainWindow.grammar);
            Main.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
    }
}
