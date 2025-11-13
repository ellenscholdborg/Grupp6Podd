using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeller;
using Affärslagret;

namespace Datalagret
{
    internal class KategoriRepository : IRepository<Kategori>
    {
        private List<Kategori> allaKategorier;

        public KategoriRepository()
        {
            allaKategorier = new List<Kategori>();
        }
        public void Add(Kategori enKategori)
        {
            allaKategorier.Add(enKategori);
        }

        // READ – hämta alla
        public List<Kategori> GetAll()
        {
            return allaKategorier;
        }

        // READ – hämta en pingvin via Id
        public Kategori? GetById(int id)
        {
            foreach (Kategori p in allaKategorier)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }

        // UPDATE – baserat på Id
        public bool Update(Kategori uppdateradKategori)
        {
            for (int i = 0; i < allaKategorier.Count; i++)
            {
                if (allaKategorier[i].Id == uppdateradKategori.Id)
                {
                    allaKategorier[i].Namn = uppdateradKategori.Namn;
                    return true;
                }
            }
            return false;
        }

        // DELETE – baserat på Id
        public bool Delete(int id)
        {
            for (int i = 0; i < allaKategorier.Count; i++)
            {
                if (allaKategorier[i].Id == id)
                {
                    allaKategorier.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}

