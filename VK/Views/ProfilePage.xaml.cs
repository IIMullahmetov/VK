using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace VK.Views
{
	/// <summary>
	/// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
	/// </summary>
	public sealed partial class ProfilePage : Page
    {
		private string uri = "https://api.vk.com/method/users.get?user_id=" + App.Api.UserId + "&v=5.52";
		public ProfilePage()
        {
            InitializeComponent();

		}
    }
}
