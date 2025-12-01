using Datalagret;
using Modeller;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslagret
{
    public class KategoriService : IKategoriService
    {
        private readonly IKategoriRepository kategoriRepo;

        public KategoriService(IKategoriRepository kategoriRepo)
        {
            this.kategoriRepo = kategoriRepo;
        }

        public Task SparaKategori(Kategori kategori)
            => kategoriRepo.SparaKategoriAsync(kategori);

        public Task<List<Kategori>> HamtaAllaKategorierAsync()
            => kategoriRepo.HamtaAllaKategorierAsync();

        public Task<bool> TaBortKategoriAsync(Kategori kategori)
            => kategoriRepo.TaBortKategoriAsync(kategori);

        public Task<bool> UppdateraKategoriNamnAsync(Kategori kategori, string nyttNamn)
            => kategoriRepo.UppdateraKategoriNamnAsync(kategori, nyttNamn);
    }

}

