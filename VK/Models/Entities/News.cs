using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace VK.Models.Entities
{
	class News
	{
		public string Text { get; set; }
		public List<Image> Images { get; set; }
		public List<Music> Musics { get; set; }
    }
}
