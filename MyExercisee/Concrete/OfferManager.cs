using MyExercisee.Abstract;
using MyExercisee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercisee.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.OfferName + "sisteme eklendi ");
        }

        public void App(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " uygulandı. ");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.OfferName + "isimli indirim guncellendi.");
        }
    }
}
