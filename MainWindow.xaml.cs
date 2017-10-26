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
using System.IO;
namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string imie;
        private string nazwisko;
        private List<string> przedmioty= new List<string>();
        private List<string> oceny=new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbimie.Visibility = Visibility.Visible;
            lbnazwisko.Visibility = Visibility.Visible;
            lboceny.Visibility = Visibility.Hidden;
            lbprzedmoty.Visibility = Visibility.Hidden;
            tbimie.Visibility = Visibility.Visible;
            tbnazwisko.Visibility = Visibility.Visible;
            tboceny.Visibility = Visibility.Hidden;
            tbprzedmioty.Visibility = Visibility.Hidden;
            this.setvisibleprzedmioty();
            this.setvisibleoceny();
        }
        private void zapis()
        {
            StreamWriter sw = new StreamWriter("Uczen.txt");
            sw.Write(imie+";"+nazwisko+";");
            for (int i = 0; i < przedmioty.Count; i++)
            {
                sw.Write(przedmioty[i] + ";" + oceny[i] + ";");
            }
            sw.Close();
        }
        private void setvisibleprzedmioty()
        {
            tbprzedmioty_Copy.Visibility = Visibility.Hidden;
            tbprzedmioty_Copy1.Visibility = Visibility.Hidden;
            tbprzedmioty_Copy2.Visibility = Visibility.Hidden;
            tbprzedmioty_Copy3.Visibility = Visibility.Hidden;
            tbprzedmioty_Copy4.Visibility = Visibility.Hidden;
            tbprzedmioty_Copy5.Visibility = Visibility.Hidden;
            
            
        }
        private void setvisibleoceny()
        {
            tboceny_Copy.Visibility = Visibility.Hidden;
            tboceny_Copy1.Visibility = Visibility.Hidden;
            tboceny_Copy2.Visibility = Visibility.Hidden;
            tboceny_Copy3.Visibility = Visibility.Hidden;
            tboceny_Copy4.Visibility = Visibility.Hidden;
            tboceny_Copy5.Visibility = Visibility.Hidden;
        }
        private void butprzedmioty_Click(object sender, RoutedEventArgs e)
        {

            lbimie.Visibility = Visibility.Hidden;
            lbnazwisko.Visibility = Visibility.Hidden;
            lboceny.Visibility = Visibility.Hidden;
            lbprzedmoty.Visibility = Visibility.Visible;
            tbimie.Visibility = Visibility.Hidden;
            tbnazwisko.Visibility = Visibility.Hidden;
            tboceny.Visibility = Visibility.Hidden;
            tbprzedmioty.Visibility = Visibility.Visible;
            
            if (tbprzedmioty_Copy.Text != "")
            {
                tbprzedmioty_Copy.Visibility = Visibility.Visible;
                if (tbprzedmioty_Copy1.Text != "")
                {
                    tbprzedmioty_Copy1.Visibility = Visibility.Visible;
                    if (tbprzedmioty_Copy2.Text != "")
                    {
                        tbprzedmioty_Copy2.Visibility = Visibility.Visible;
                        if (tbprzedmioty_Copy3.Text != "")
                        {
                            tbprzedmioty_Copy3.Visibility = Visibility.Visible;
                            if (tbprzedmioty_Copy4.Text != "")
                            {
                                tbprzedmioty_Copy4.Visibility = Visibility.Visible;
                                if (tbprzedmioty_Copy5.Text != "")
                                {
                                    tbprzedmioty_Copy5.Visibility = Visibility.Visible;

                                }
                            }
                        }
                    }
                }
            }
            this.setvisibleoceny();
        }

        private void butoceny_Click(object sender, RoutedEventArgs e)
        {

            lbimie.Visibility = Visibility.Hidden;
            lbnazwisko.Visibility = Visibility.Hidden;
            lboceny.Visibility = Visibility.Visible;
            lbprzedmoty.Visibility = Visibility.Hidden;
            tbimie.Visibility = Visibility.Hidden;
            tbnazwisko.Visibility = Visibility.Hidden;
            tboceny.Visibility = Visibility.Visible;
            tbprzedmioty.Visibility = Visibility.Hidden;
            if (tboceny_Copy.Text != "")
            {
                tboceny_Copy.Visibility = Visibility.Visible;
                if (tboceny_Copy1.Text != "")
                {
                    tboceny_Copy1.Visibility = Visibility.Visible;
                    if (tboceny_Copy2.Text != "")
                    {
                        tboceny_Copy2.Visibility = Visibility.Visible;
                        if (tboceny_Copy3.Text != "")
                        {
                            tboceny_Copy3.Visibility = Visibility.Visible;
                            if (tboceny_Copy4.Text != "")
                            {
                                tboceny_Copy4.Visibility = Visibility.Visible;
                                if (tboceny_Copy5.Text != "")
                                {
                                    tboceny_Copy5.Visibility = Visibility.Visible;

                                }
                            }
                        }
                    }
                }
            }
            this.setvisibleprzedmioty();
        }

        private void butpotwierdz_Click(object sender, RoutedEventArgs e)
        {
            imie = tbimie.Text;
            nazwisko = tbnazwisko.Text;

            if (tbprzedmioty.Text != "")
            {
                przedmioty.Add(tbprzedmioty.Text);
                if (tbprzedmioty_Copy.Text != "")
                {
                    przedmioty.Add(tbprzedmioty_Copy.Text);
                    if (tbprzedmioty_Copy1.Text != "")
                    {
                        przedmioty.Add(tbprzedmioty_Copy1.Text);
                        if (tbprzedmioty_Copy2.Text != "")
                        {
                            przedmioty.Add(tbprzedmioty_Copy2.Text);
                            if (tbprzedmioty_Copy3.Text != "")
                            {
                                przedmioty.Add(tbprzedmioty_Copy3.Text);
                                if (tbprzedmioty_Copy4.Text != "")
                                {
                                    przedmioty.Add(tbprzedmioty_Copy4.Text);
                                    if (tbprzedmioty_Copy5.Text != "")
                                    {
                                        przedmioty.Add(tbprzedmioty_Copy5.Text);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            if (tboceny.Text != "")
            {
                oceny.Add(tboceny.Text);
                if (tboceny_Copy.Text != "")
                {
                    oceny.Add(tboceny_Copy.Text);
                    if (tboceny_Copy1.Text != "")
                    {
                        oceny.Add(tboceny_Copy1.Text);
                        if (tboceny_Copy2.Text != "")
                        {
                            oceny.Add(tboceny_Copy2.Text);
                            if (tboceny_Copy3.Text != "")
                            {
                                oceny.Add(tboceny_Copy3.Text);
                                if (tboceny_Copy4.Text != "")
                                {
                                    oceny.Add(tboceny_Copy4.Text);
                                    if (tboceny_Copy5.Text != "")
                                    {
                                        oceny.Add(tboceny_Copy5.Text);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void butzapiszdopliku_Click(object sender, RoutedEventArgs e)
        {
            this.zapis();
        }

        
        private void tbprzedmioty_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbprzedmioty_Copy1.Visibility = Visibility.Visible;
        }

        private void tbprzedmioty_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbprzedmioty_Copy2.Visibility = Visibility.Visible;
        }
        private void tbprzedmioty_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbprzedmioty_Copy3.Visibility = Visibility.Visible;
        }
        private void tbprzedmioty_Copy3_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbprzedmioty_Copy4.Visibility = Visibility.Visible;
        }
        private void tbprzedmioty_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbprzedmioty_Copy5.Visibility = Visibility.Visible;
        }

        private void tbprzedmioty_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbprzedmioty_Copy.Visibility = Visibility.Visible;
        }

        private void tboceny_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            tboceny_Copy1.Visibility = Visibility.Visible;
        }

        private void tboceny_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tboceny_Copy2.Visibility = Visibility.Visible;
        }
        private void tboceny_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tboceny_Copy3.Visibility = Visibility.Visible;
        }
        private void tboceny_Copy3_TextChanged(object sender, TextChangedEventArgs e)
        {
            tboceny_Copy4.Visibility = Visibility.Visible;
        }
        private void tboceny_Copy4_TextChanged(object sender, TextChangedEventArgs e)
        {
            tboceny_Copy5.Visibility = Visibility.Visible;
        }

        private void tboceny_TextChanged(object sender, TextChangedEventArgs e)
        {
            tboceny_Copy.Visibility = Visibility.Visible;
        }

        
    }
}
