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
using TestReken.Library;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace test_reken
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
   
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            
            this.InitializeComponent();
        }

        double eersteGetal = 0;
        string teken = "";
        public void GetalInput(Button button)
        {
            textBox1.Text += button.Content;
            textBox2.Text += button.Content;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button2);

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button3);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button4);

        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button5);

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button6);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button8);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button9);
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            GetalInput(button10);
        }

        private void Button_Click(object sender, RoutedEventArgs e) //VERMENIGVULDIGEN
        {
            Clas.Vermenigvuldigen(textBox1, textBox2, ref teken, ref eersteGetal);
        }

        private void Equals_Click(object sender, RoutedEventArgs e) //ISGELIJKAAN
        {
            Clas.IsGelijkAan(eersteGetal, textBox1, textBox2, listbox1, teken);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e) //GESCHIEDENIS OPHALEN
        {
            Clas.LoadHistory(listbox1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // DELEN
        {
            Clas.Delen(textBox1, textBox2, ref teken, ref eersteGetal);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Clas.Aftrekken(textBox1, textBox2, ref teken, ref eersteGetal);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Clas.Optellen(textBox1, textBox2, ref teken, ref eersteGetal);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Clas.TweedeMacht(textBox1, textBox2);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Clas.Clear(textBox1, textBox2, ref teken, ref eersteGetal);
        }
    }
}
