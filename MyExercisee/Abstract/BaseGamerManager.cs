using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExercisee.Entities;

namespace MyExercisee.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Doğrulama basarıyla tamamlandı ve " + gamer.FirstName + " sisteme kaydedildi.");
        }
     

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Guncelleme işlemi yapıldı."+ gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Silme işlemi yapıldı." + gamer.FirstName);
        }
        public virtual void Buy(Gamer gamer)
        {
            Console.WriteLine("Alım işlemi yapıldı." + gamer.FirstName);
        }
    }
}
