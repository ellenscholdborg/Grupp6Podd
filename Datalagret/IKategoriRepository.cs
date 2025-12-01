using Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalagret
{
    public interface IKategoriRepository
    {
        Task SparaKategoriAsync(Kategori kategori);
        Task<List<Kategori>> HamtaAllaKategorierAsync();
        Task<bool> TaBortKategoriAsync(Kategori kategori);
        Task<bool> UppdateraKategoriNamnAsync(Kategori kategori, string nyttNamn);
    }
}
