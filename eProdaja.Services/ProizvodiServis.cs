using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiServis : IProizvodiService
    {
        public List<Proizvodi> ProizvodiList = new List<Proizvodi>() { new Proizvodi() { ID = 1, Naziv = "Laptop" }, new Proizvodi() { ID = 2, Naziv = "Mis" } };

        public IEnumerable<Proizvodi> Get()
        {
            ProizvodiList.Add(new Proizvodi() { Naziv = "Test", ID = 3 });
            return ProizvodiList;
        }

        public Proizvodi GetID(int id)
        {
            return ProizvodiList.FirstOrDefault(x => x.ID == id);
        }

    }
}   
