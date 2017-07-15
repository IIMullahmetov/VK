using System.IO;
using VkNet;
using VkNet.Enums.Filters;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace VK.Views
{
	/// <summary>
	/// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
	/// </summary>
	public sealed partial class AuthenticationPage : Page
    {
		public AuthenticationPage() => InitializeComponent();

		private async void Enter_Click(object sender, RoutedEventArgs e)
		{
			VkApi api = App.Api;
			await api.AuthorizeAsync(new ApiAuthParams()
			{
				Settings = Settings.All,
				Login = EmailOrPhone.Text,
				Password = Password.Password,
				ApplicationId = App.AppId
			});
			App.Token = App.Api.Token;
			StorageFolder localFolder = ApplicationData.Current.LocalFolder;
			File.Create(localFolder.Path + "Token.txt");
			File.WriteAllText(localFolder.Path + "Token.txt", App.Token);

		}
	}
}
