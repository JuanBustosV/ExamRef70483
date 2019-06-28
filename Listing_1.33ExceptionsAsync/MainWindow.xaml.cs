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

namespace Listing_1._33ExceptionsAsync
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task<string> FetchWebPage(string url)
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResultTextBlock.Text = await FetchWebPage(URLTextBox.Text);
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
