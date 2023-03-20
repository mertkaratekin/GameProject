using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Abstract
{
    public interface IOfferService
    {
        void App(Offer offer);
        void Add(Offer offer);
        void Update(Offer offer);

    }
}
