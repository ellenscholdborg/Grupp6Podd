using System.Net.Http;
using Datalagret;
using Affärslagret;


namespace Presentationslagret
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Manual dependency wiring
            var mongo = new MongoDBService();
            var kategoriRepo = new KategoriRepository(mongo);
            var poddRepo = new PoddRepository(mongo.GetDatabase());

            var kategoriService = new KategoriService(kategoriRepo);
            var poddRss = new PoddRSS(new HttpClient());
            var poddService = new PoddService(poddRss, poddRepo);

            Application.Run(new Form1(poddService, kategoriService));
        }
    }
}