using Affärslagret;
using Datalagret;
using Modeller;
using MongoDB.Driver;
using System.Windows.Forms;


namespace Presentationslagret
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            HttpClient http = new HttpClient();
            var klient = new PoddRSS(http);

            var mongoService = new MongoDBService();
            var databas = mongoService.GetDatabase();

            var kategoriRepo = new KategoriRepository(databas);
            var poddRepo = new PoddRepository(databas);

            var kategoriService = new KategoriService(kategoriRepo);
            var poddService = new PoddService(klient, poddRepo);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(poddService, kategoriService));
        }
    }
}