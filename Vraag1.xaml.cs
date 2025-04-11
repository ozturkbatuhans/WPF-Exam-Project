using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Batuhan_Ozturk_Examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            lstFrequenties.Items.Clear();

            string sinputText = txtInput.Text.ToLower();

            string scleanText = Regex.Replace(sinputText, @"[.,;!?]", "");

            List<string> wordsList = new List<string>();
            string currentWord = "";

            foreach (char c in scleanText)
            {
                if (c == ' ' || c == '\n' || c == '\r')
                {
                    
                    if (!string.IsNullOrEmpty(currentWord))
                    {
                        wordsList.Add(currentWord);
                        currentWord = "";
                    }
                }
                else
                {
                   
                    currentWord += c;
                }
            }
            
            if (!string.IsNullOrEmpty(currentWord))
            {
                wordsList.Add(currentWord);
            }

            string[] words = wordsList.ToArray();


            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int count = 0;

                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == word)
                    {
                        count++;
                    }
                }

                bool alreadyExists = false;
                for (int k = 0; k < lstFrequenties.Items.Count; k++)
                {
                    if (lstFrequenties.Items[k].ToString().StartsWith($"{word}"))
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    lstFrequenties.Items.Add($"{word} : {count} ");
                }
            }
        }
    }
}

