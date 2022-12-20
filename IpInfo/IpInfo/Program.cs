using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace IpInfo
{
    internal class Program
    {
        public static string ipaddres;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter IP:");
            ipaddres = Console.ReadLine();
            GetIpInfo();
            Console.ReadLine();
        }
        public static async Task GetIpInfo()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "IPInfo App");
            var json = await client.GetStringAsync("https://ipapi.co/" + ipaddres + "/json/");
            Console.WriteLine("Result for: " + ipaddres + Environment.NewLine + "Info: " + json + Environment.NewLine + Environment.NewLine); //MessageBox.Show("SILENTNIGHT LOGGER" + Environment.NewLine + "IP Location: " + jsone + Environment.NewLine + Environment.NewLine + "Copied info to clipboard!");
        }

    }
}
