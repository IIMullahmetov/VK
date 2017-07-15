using ModernDev.InTouch;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VK.Models
{
    class FriendsRepository
    {
		
		public async void GetFriends()
		{
			//string uri = new StringBuilder().Append(Parametrs.URI).
			//	Append("friend.getLists?user_id=1&access_token=").
			//	Append("cd3e507958289b793b4efcfdb3579e0ecb3cde23dbb84da187d2537b386df919a43e77d1137bcacb72ad4v=5.67").
			//	ToString();
			//HttpClient client = new HttpClient();
			//HttpResponseMessage response = await client.GetAsync(new Uri(uri));
			//HttpStatusCode code = response.StatusCode;
			//string body = await response.Content.ReadAsStringAsync();
			
			////WebResponse response = await request.GetResponseAsync();
			//Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(body);
			////foreach(string s in dictionary.Values)
			////{
			////	Debug.Write(s);
			////}
		}
    }
}
