using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeaugeOfLegendsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://na.api.pvp.net/api/lol/na/v2.2/match/1900729148?api_key=da9643c8-6599-4608-adad-ecfe2e8007ce";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
            // request.Method = "Get";
            WebResponse response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            var json = Newtonsoft.Json.JsonConvert.DeserializeObject<MatchResponse>(responseData);

            
        }
    }
}
