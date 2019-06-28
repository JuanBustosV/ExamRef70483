using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Listing_1._34AwaitingParallelTasks
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static async Task<string> FetchWebPage(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        static async Task<IEnumerable<string>> FetchWebPages( string [] urls)
        {
            var tasks = new List<Task<string>>();

            foreach (string url in urls)
            {
                tasks.Add(FetchWebPage(url));
            }

            return await Task.WhenAll(tasks);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] names = URLTextBox.Text.Split(new char[] { ',' });

                var pages = await FetchWebPages(names);

                string fullText = "";

                foreach (string page in pages)
                {
                    fullText += page;
                }
                ResultTextBlock.Text = fullText;
                StatusTextBlock.Text = "Page Loaded";
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = string.Empty;
                StatusTextBlock.Text = ex.Message;
            }
        }
    }
}
