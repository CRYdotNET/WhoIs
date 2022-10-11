using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Net;

namespace IpInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter IP:");
            string ipaddress = Console.ReadLine();
            using (var objClient = new System.Net.WebClient())
            {
                WebClient clientpenis = new WebClient();
                string bruh = clientpenis.DownloadString("http://ip-api.com/json/" + ipaddress);  //http://ip-api.com/json/
                string hecko = bruh;
                var Listo = new List<string> { bruh };
                var tags = new { tags = Listo };

                string result = string.Empty;
                
                JObject jsone = JObject.Parse(bruh);



                Console.WriteLine("Result for:" + ipaddress + Environment.NewLine + "Info: " + jsone + Environment.NewLine + Environment.NewLine); 
                Console.ReadLine();
            }
        }
    }
}
