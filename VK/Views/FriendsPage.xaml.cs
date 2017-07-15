using System;
using System.Net;
using VK.Models;
using VkNet;
using VkNet.Model.RequestParams;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace VK.Views
{
	/// <summary>
	/// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
	/// </summary>
	public sealed partial class FriendsPage : Page
    {

		public FriendsPage()
        {
			InitializeComponent();
			FriendsRepository repository = new FriendsRepository();
			repository.GetFriends();
        }
    }
}
