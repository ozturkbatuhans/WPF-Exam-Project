using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Batuhan_Ozturk_Examen
{
    /// <summary>
    /// Interaction logic for Vraag2.xaml
    /// </summary>
    public partial class Vraag2 : Window
    {
        public Vraag2()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {

            lstResults.Items.Clear();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(500, 1501);
                int temp = number;
                string result = "";

                while (temp > 0)
                {
                    int digit = temp % 10;

                    switch (digit)
                    {
                        case 0:
                            result = "nul " + result;
                            break;
                        case 1:
                            result = "een " + result;
                            break;
                        case 2:
                            result = "twee " + result;
                            break;
                        case 3:
                            result = "drie " + result;
                            break;
                        case 4:
                            result = "vier " + result;
                            break;
                        case 5:
                            result = "vijf " + result;
                            break;
                        case 6:
                            result = "zes " + result;
                            break;
                        case 7:
                            result = "zeven " + result;
                            break;
                        case 8:
                            result = "acht " + result;
                            break;
                        case 9:
                            result = "negen " + result;
                            break;
                    }

                    temp /= 10; 
                }

                lstResults.Items.Add(number.ToString() + ": " + result.Trim());
            }
        }
    }
}