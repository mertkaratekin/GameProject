using MyApplication.Abstract;
using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Concrete
{
    public class AOfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.OfferName + "sisteme eklendi");
        }

        public void App(Offer offer)
        {
            Console.Write(offer.OfferName + " uygulanarak ");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.OfferName + "isimli indirim guncellendi.");
        }
    }
}
