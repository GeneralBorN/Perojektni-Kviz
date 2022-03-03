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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Perojektni_Kviz
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        //deklaracija varijabli
        int tocniOdgovor;
        int brojPitanja;
        int score;
        int ukupnoPitanja;
        
        public BlankPage1()
        {
            this.InitializeComponent();
        }
        
        
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        
        
        private void postaviPitanje(int qnum)
        {
            switch(qnum)//broj pitanja, te postavlja nova pitanja i tocne odgovore
            {
                case 1://pitanje 1.

                    break;//zaustavlja switch
                case 2://pitanje 2. itd
                    break;
            }
        }
    }
}
