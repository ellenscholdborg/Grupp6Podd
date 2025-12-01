using Modeller;
using MongoDB.Bson.Serialization.Serializers;

namespace Datalagret
{
    public interface IPoddRepository
    {
        Task SparaPoddAsync(Podd podd);
        Task<List<Podd>> HamtaPoddarForKategoriAsync(string kategoriId);
        Task<bool> TaBortPoddAsync(Podd podd);
        Task<bool> UppdateraPoddNamnAsync(Podd podd, string nyttNamn);
        Task<bool> UppdateraPoddKategoriAsync(Podd podd, string nyKategoriId);
    }
}
