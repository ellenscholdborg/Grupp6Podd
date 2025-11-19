
using Modeller;


namespace Datalagret
{
    public class PoddRepository : IRepository<Podd>
    {
        private List<Podd> allaPoddar;

        public PoddRepository()
        {
            allaPoddar = new List<Podd>();
        }
        public void Add(Podd enPodd)
        {
            allaPoddar.Add(enPodd);
        }

        // READ – hämta alla
        public List<Podd> GetAll()
        {
            return allaPoddar;
        }

        // READ – hämta en pingvin via Id
        public Podd? GetById(string id)
        {
            foreach (Podd p in allaPoddar)
            {
                if (p.Id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

        // UPDATE – baserat på Id
        public bool Update(Podd uppdateradPodd)
        {
            for (int i = 0; i < allaPoddar.Count; i++)
            {
                if (allaPoddar[i].Id == uppdateradPodd.Id)
                {
                    allaPoddar[i].Namn = uppdateradPodd.Namn;
                    return true;
                }
            }
            return false;
        }

        // DELETE – baserat på Id
        public bool Delete(Podd id)
        {
            for (int i = 0; i < allaPoddar.Count; i++)
            {
                if (allaPoddar[i].Id.Equals(id))
                {
                    allaPoddar.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}

