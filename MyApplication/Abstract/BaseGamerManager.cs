using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncuya satıldı.");
        }

        

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Guncelleme işlemi yapıldı."+ gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Silme işlemi yapıldı." + gamer.FirstName);
        }
    }
}
