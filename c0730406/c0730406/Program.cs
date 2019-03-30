using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730406
{
    class Program
    {

        static void Main(string[] args)
        {
            {

                Console.WriteLine("Downloading file");
                Download();
                Console.ReadLine();
            }

        }
        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download complete");
        }
        class Network
        {
            static ArrayList WebPageContents = new ArrayList();
            private static object i;

            public static async Task Download()
            {
                HttpClient client = new HttpClient();
                String data = await client.GetStringAsync("http://torontopubliclibrary.ca");
                //  Console.WriteLine(data);
                foreach (var i in data) ;
                {
                    WebPageContents.Add(i);
                }
            }
        }
    }


   

