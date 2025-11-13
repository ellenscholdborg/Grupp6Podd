using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeller;
using Affärslagret;


namespace Datalagret
{
    public class AvsnittRepository : IRepository<Avsnitt>
    {
        private List<Avsnitt> allaAvsnitt;

        public AvsnittRepository()
        {
            allaAvsnitt = new List<Avsnitt>();
        }
        public void Add(Avsnitt ettAvsnitt
            )
        {
            allaAvsnitt.Add(ettAvsnitt);
        }

        // READ – hämta alla
        public List<Avsnitt> GetAll()
        {
            return allaAvsnitt;
        }

        // READ – hämta en pingvin via Id
        public Avsnitt? GetById(int id)
        {
            foreach (Avsnitt p in allaAvsnitt)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }

        // UPDATE – baserat på Id
        public bool Update(Avsnitt uppdateratAvsnitt)
        {
            for (int i = 0; i < allaAvsnitt.Count; i++)
            {
                if (allaAvsnitt[i].Id == uppdateratAvsnitt.Id)
                {
                    allaAvsnitt[i].Namn = uppdateratAvsnitt.Namn;
                    return true;
                }
            }
            return false;
        }

        // DELETE – baserat på Id
        public bool Delete(int id)
        {
            for (int i = 0; i < allaAvsnitt.Count; i++)
            {
                if (allaAvsnitt[i].Id == id)
                {
                    allaAvsnitt.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}

