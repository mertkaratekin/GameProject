using MyExercisee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercisee.Abstract
{
    public interface IOfferService
    {
        void App(Offer ofter);
        void Add(Offer offer);
        void Update(Offer offer);
    }
}
