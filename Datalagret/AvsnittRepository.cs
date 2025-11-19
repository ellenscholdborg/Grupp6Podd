using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeller;


namespace Datalagret
{
    public class AvsnittRepository : IRepository<Avsnitt>
    {
        private List<Avsnitt> allaAvsnitt;

        public AvsnittRepository()
        {
            allaAvsnitt = new List<Avsnitt>();
        }
        public void Add(Avsnitt ettAvsnitt)
        {
            allaAvsnitt.Add(ettAvsnitt);
        }

        // READ – hämta alla
        public List<Avsnitt> GetAll()
        {
            return allaAvsnitt;
        }

        // READ – hämta en pingvin via Id
        public Avsnitt? GetById(string id)
        {
            foreach (Avsnitt p in allaAvsnitt)
            {
                if (p.Id.Equals(id)) 
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
                    allaAvsnitt[i].Rubrik = uppdateratAvsnitt.Rubrik;
                    return true;
                }
            }
            return false;
        }

        // DELETE – baserat på Id
        public bool Delete(Avsnitt id)
        {
            for (int i = 0; i < allaAvsnitt.Count; i++)
            {
                if (allaAvsnitt[i].Id.Equals(id))
                {
                    allaAvsnitt.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}

