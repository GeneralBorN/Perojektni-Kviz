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
       
        int score=0;
        int ukupnoPitanja=20;
        int trenutnoPitanje = 1;
        double percentage;

        public BlankPage1()
        {
            this.InitializeComponent();

           
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
                    pitanja.Text = "Izraz 'Računalo' potječe od ……….? latinski" 
                        +"\n A-Computer" + "  B-Computing" + "\n C-Compjuter" + "  D-Compute";
                    tocniOdgovor = 1;

                    break;//zaustavlja switch


                case 2:
                    pitanja.Text = "Tko je izumitelj “Difference Engine”? "
                        + "\n A-Charles Dickens" + "  B-Charles Babbage" + "\n C-Charles Darwin" + "  D-Charles Pearce"; 
                    tocniOdgovor = 2;
                    break;


                case 3:
                    pitanja.Text = "Tko je otac informatike? "
                        + "\n A-Allen Iverson" + "  B-Allen Greene" + "\n C-Allen Turing" + "  D-Allen Bradley";
                    tocniOdgovor = 3;
                    break;
                case 4:
                    pitanja.Text = "Tko je otac osobnog računala? "
                        + "\n A-Edward Snownden" + "  B-Charles Furlong" + "\n C-Bernays" + "  D- Edward Robert";
                    tocniOdgovor = 4;
                    break;
                case 5:
                    pitanja.Text = "CPU sadrži? "
                        + "\n A-upravljačku i aritmetičko-logičku jedinicu" + "  B-Upravljačku" + "\n C-Aritmetičku" + "  D-Logičku";
                    tocniOdgovor = 1;
                    break;
                case 6:
                    pitanja.Text = "Što od sljedećeg kontrolira proces interakcije između korisnika i operacijskog sustava?"
                        + "\n A-Korisničko iskustvo" + "  B-Korisničko sučelje" + "\n C-Korisničko povezivanje" + "  D-Korisnička mreža";
                    tocniOdgovor = 2;
                    break;
                case 7:
                    pitanja.Text = "Prva računala programirana su pomoću?"
                        + "\n A-Programskog jezika" + "  B- Strojnog ciklusa" + "\n C-Strojnog jezika" + "  D-Strojne UI";
                    tocniOdgovor = 3;
                    break;
                case 8:
                    pitanja.Text = "Kombinacija hardvera i softvera koja olakšava dijeljenje informacija između računalnih uređaja?"
                        + "\n A-Elektroni" + "  B-Sabirnice" + "\n C-Računalni sustav" + "  D-mreža";
                    tocniOdgovor = 4;
                    break;
                case 9:
                    pitanja.Text = "Kako se nazivaju kodirani unosi koji se koriste za pristup računalnom sustavu?"
                        + "\n A-Lozinke" + "  B-Username" + "\n C-Znakovi" + "  D-Skriveni brojevi";
                    tocniOdgovor = 1;
                    break;
                case 10:
                    pitanja.Text = "Datoteke organizirate tako da ih pohranjujete?"
                        + "\n A-U aplikacije" + "  B-U mape" + "\n C-Na programsku traku" + "  D-U koš za smeće";
                    tocniOdgovor = 2;
                    break;
                case 11:
                    pitanja.Text = "Koja će vrsta resursa najvjerojatnije biti zajednički  resurs u računalnoj mreži?"
                        + "\n A-3D printeri" + "  B-Routeri" + "\n C-Pisači" + "  D-Switchevi";
                    tocniOdgovor = 3;
                    break;
                case 12:
                    pitanja.Text = "Koji je uređaj potreban za internetsku vezu? "
                         + "\n A-Server" + "  B-Akumulator" + "\n C-Router" + "  D-Modem";
                    tocniOdgovor = 4;
                    break;
                case 13:
                    pitanja.Text = "Što je svjetlosna olovka? Optički ulazni uređaj"
                         + "\n A- Optički ulazni uređaj" + "  B-Igrači" + "\n C-Pokazivački" + "  D-Zvučni";
                    tocniOdgovor = 1;
                    break;
                case 14:
                    pitanja.Text = "UNIVAC je?"
                         + "\n A- Univerzalno računalo" + "  B- Univerzalno automatsko računalo" + "\n C- Univerzalno digitalno računalo" + "  D- Univerzalno serversko računalo";
                    tocniOdgovor = 2;
                    break;
                case 15:
                    pitanja.Text = "CD-ROM znači?"
                         + "\n A-Memorija za pisanje" + "  B- Memorija na CD-u" + "\n C-Kompaktibilna memorija samo za čitanje" + "  D-Kompaktibilna memorija samo za pisanje";
                    tocniOdgovor = 3;
                    break;
                case 16:
                    pitanja.Text = "ALU je? "
                         + "\n A-Aritmetičko upravljačka jedinica" + "  B-Adresna jedinica" + "\n C-Programska jedinica" + "  D-Aritmetičko logička jedinica";
                    tocniOdgovor = 4;
                    break;
                case 17:
                    pitanja.Text = "VGA je?"
                         + "\n A-Video grafički niz" + "  B-Video grafička oznaka" + "\n C-Video grafička jedinica" + "  D-Video grafički stupac";
                    tocniOdgovor = 1;
                    break;
                case 18:
                    pitanja.Text = "IBM 1401"
                         + "\n A-je prva generacija računala" + "  B-je druga generacija računala" + "\n C-je treća generacija računala" + "  D-je četvrta generacija računala";
                    tocniOdgovor = 2;
                    break;
                case 19:
                    pitanja.Text = "MSI znači?"
                         + "\n A-Integrirani krugovi niske veličine" + "  B-Integrirani krugovi" + "\n C-Integrirani krugovi srednje veličine" + "  D-Integrirani krugovi visoke veličine";
                    tocniOdgovor = 3;
                    break;
                case 20:
                    pitanja.Text = "Tko je otac računala?"
                         + "\n A-Charles Bakkage" + "  B-Charles Ballage" + "\n C-Charles Baggage" + "  D-Charles Babbage";
                    tocniOdgovor = 4;
                    break;
               
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            
            if(Convert.ToInt32(senderObject.AccessKey)==tocniOdgovor)
            {
                score++;
            }

            if (trenutnoPitanje == ukupnoPitanja)
            {
                percentage = score/20.0*100;
   
                pitanja.Text ="Tvoj score je: " + score.ToString();
                

            }
            else
            {
                trenutnoPitanje++;
                postaviPitanje(trenutnoPitanje);
            }
        }
    }
}
