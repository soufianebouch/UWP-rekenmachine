using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TestReken.Library
{
    public class Clas
    {

        public static double Berekenen(double getal1, double getal2, string operat)
        {
            double result = 0;
            switch (operat)
            {
                case "+":


                    result = getal1 + getal2;
                    break;
                case "-":
                    result = getal1 - getal2;
                    break;
                case "*":
                    result = getal1 * getal2;
                    break;
                case "/":
                    result = getal1 / getal2;
                    break;
            }
            return result;
        }
        public async static void IsGelijkAan(double eersteGetal, TextBox textBox1, TextBox textBox2, ListBox listbox1, string teken)
        {
            if (eersteGetal == 0)
            {
                textBox1.Text = textBox1.Text;
                listbox1.Items.Add(textBox1.Text);

                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("sample.txt");

                await Windows.Storage.FileIO.AppendTextAsync(sampleFile, "\n" + textBox2.Text);
            }
            else if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(Clas.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken));
                eersteGetal = 0;
                teken = "";
                textBox2.Text = textBox1.Text;

                listbox1.Items.Add(textBox1.Text);

                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("sample.txt");

                await Windows.Storage.FileIO.AppendTextAsync(sampleFile, "\n" + textBox2.Text);

            }
        }
        public async static void LoadHistory(ListBox listbox1)
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("sample.txt");

            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);

            listbox1.Items.Add(text);
        }

        public static void Delen(TextBox textBox1, TextBox textBox2, ref string teken, ref double eersteGetal)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    teken = "/";
                    textBox2.Text += "/";
                }
                else
                {
                    eersteGetal = Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Text = "";
                    teken = "/";
                    textBox2.Text = eersteGetal + "/";
                }
            }
        }
        public static void Vermenigvuldigen(TextBox textBox1, TextBox textBox2, ref string teken, ref double eersteGetal)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    teken = "*";
                    textBox2.Text += "*";
                }
                else
                {
                    eersteGetal = Clas.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Text = "";
                    teken = "*";
                    textBox2.Text = eersteGetal + "*";
                }
            }
        }
        public static void Aftrekken(TextBox textBox1, TextBox textBox2, ref string teken, ref double eersteGetal)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    teken = "-";
                    textBox2.Text += "-";
                }
                else
                {
                    eersteGetal = Clas.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Text = "";
                    teken = "-";
                    textBox2.Text = textBox2.Text + "-";
                }
            }
        }
        public static void Optellen(TextBox textBox1, TextBox textBox2, ref string teken, ref double eersteGetal)
        {
            if (textBox1.Text != "")
            {
                if (teken == "")
                {
                    eersteGetal = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    teken = "+";
                    textBox2.Text += "+";
                }
                else
                {
                    eersteGetal = Clas.Berekenen(eersteGetal, double.Parse(textBox1.Text), teken);
                    textBox1.Text = "";
                    teken = "+";
                    textBox2.Text = eersteGetal + "+";
                }
            }
        }
        public static void TweedeMacht(TextBox textBox1, TextBox textBox2)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = Convert.ToString(double.Parse(textBox1.Text) * double.Parse(textBox1.Text));
                textBox2.Text += "²";
            }
        }
        public static void Clear(TextBox textBox1, TextBox textBox2, ref string teken, ref double eersteGetal)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            eersteGetal = 0;
            teken = "";
        }
    }
}
