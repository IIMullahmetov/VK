using System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace VK.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

		private void Humburger_Click(object sender, RoutedEventArgs e)
		{
			Split.IsPaneOpen = !Split.IsPaneOpen;
		}

		private void Profile_Click(object sender, RoutedEventArgs e)
		{
			Profile.IsChecked = false;
			Frame.Navigate(typeof(ProfilePage));
			ApplicationView.GetForCurrentView().Title = "Profile";
		}

		private void News_Click(object sender, RoutedEventArgs e)
		{
			News.IsChecked = false;
			Frame.Navigate(typeof(NewsPage));
			ApplicationView.GetForCurrentView().Title = "News";
		}

		private void Messages_Click(object sender, RoutedEventArgs e)
		{
			Messages.IsChecked = false;
			Frame.Navigate(typeof(MessagesPage));
			ApplicationView.GetForCurrentView().Title = "Messages";
		}

		private void Friends_Click(object sender, RoutedEventArgs e)
		{
			Friends.IsChecked = false;
			Frame.Navigate(typeof(FriendsPage));
			ApplicationView.GetForCurrentView().Title = "Friends";
		}

		private void Groups_Click(object sender, RoutedEventArgs e)
		{
			Groups.IsChecked = false;
			Frame.Navigate(typeof(GroupsPage));
			ApplicationView.GetForCurrentView().Title = "Groups";
		}

		private void Settings_Click(object sender, RoutedEventArgs e)
		{
			Settings.IsChecked = false;
			Frame.Navigate(typeof(SettingsPage));
			ApplicationView.GetForCurrentView().Title = "Settings";
		}

		private void Refresh_Click(object sender, RoutedEventArgs e)
		{
			//Type type = Frame.CurrentSourcePageType.GetType();
			//Frame.GoBack();
			//Frame.Navigate(type);
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Frame.GoBack();
			}
			catch
			{
				
			}
			GC.Collect();
		}
	}
}
