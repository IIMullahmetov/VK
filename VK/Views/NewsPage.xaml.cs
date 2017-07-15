using VkNet;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace VK.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class NewsPage : Page
    {
		public NewsPage()
        {
            InitializeComponent();
        }

		private void Test_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
