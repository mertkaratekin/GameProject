using MyExercisee.Abstract;
using MyExercisee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercisee.Concrete
{
    public class SaleManager :  ISaleService
    {
        public void Information(Gamer gamer, Offer offer, Game game)
        {
            Console.WriteLine(gamer.FirstName + offer.OfferName + " nden yararlanarak " + game.Name + " oyununu satın aldı.");
        }

        
    }
}
