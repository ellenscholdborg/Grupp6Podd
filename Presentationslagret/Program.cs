using Affärslagret;
using Datalagret;
using Modeller;
using MongoDB.Driver;
using System.Windows.Forms;


namespace Presentationslagret
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            HttpClient http = new HttpClient();
            var klient = new PoddRSS(http);

            var service = new PoddService(klient);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(service));
        }
    }
}