using Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalagret;

namespace Affärslagret
{
    public class PoddService
    {
        private PoddRSS poddKlient;

        public PoddService(PoddRSS klient)
        {
            this.poddKlient = klient;
        }

        public async Task<List<Avsnitt>> LasInAllaAvsnitt(Podd källa)
        {
           
            var ettAvsnitt = await poddKlient.HamtaAvsnitt(källa.Url);

            foreach (var avsnitt in ettAvsnitt)
            {
                avsnitt.KällaReferens = källa.Id;
                avsnitt.Id = källa.Id + "-->" + avsnitt.Id;
            }

            return ettAvsnitt;
        }



    }
}

