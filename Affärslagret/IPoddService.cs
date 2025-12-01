using Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslagret
{
    public interface IPoddService
    {
        Task SparaPoddAsync(Podd podd);
        Task<List<Podd>> HamtaPoddarForKategoriAsync(string kategoriId);
        Task<bool> TaBortPoddflodeAsync(Podd podd);
        Task<bool> UppdateraPoddflodeNamnAsync(Podd podd, string nyttNamn);
        Task<bool> UppdateraPoddKategoriAsync(Podd podd, string nyKategoriId);
        Task<List<Avsnitt>> LasInAllaAvsnitt(Podd källa);
        Task<string> HamtaPoddTitel(string rssUrl);

    }
}
