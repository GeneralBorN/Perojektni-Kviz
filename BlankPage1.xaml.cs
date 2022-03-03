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
        int score=0;
        int ukupnoPitanja;
        int trenutnoPitanje = 1;
        int percentage;

        public BlankPage1()
        {
            this.InitializeComponent();

            brojPitanja = 20;
            postaviPitanje(trenutnoPitanje);
        }
        
        
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        
        
        private void postaviPitanje(int qnum)
        {
            switch(qnum)//broj pitanja, te postavlja nova pitanja i tocne odgovore
            {
                case 1://pitanje 1.
                    pitanja.Text = "Tko je tocan odgovor?";
                    tocniOdgovor = 1;
                    break;//zaustavlja switch
                case 2://pitanje 2. itd
                    pitanja.Text = "tako je!";
                    break;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(trenutnoPitanje==tocniOdgovor)
            {
                score++;
            }

            if(trenutnoPitanje==ukupnoPitanja)
            {
                percentage = (int)Math.Round((double)(score * 100) / ukupnoPitanja);
                score = 0;
                trenutnoPitanje = 0;
            }
            trenutnoPitanje++;
            postaviPitanje(trenutnoPitanje);
        }
    }
}
