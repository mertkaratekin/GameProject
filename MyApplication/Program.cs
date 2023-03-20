using MyApplication.Abstract;
using MyApplication.Entities;
using MyApplication.Concrete;
using MernisServiceReference;
using System;
using MyApplication.Adapters;

namespace MyApplication
{

    class Program
    {
        private static void Main(string[] args)
        {
           
            Offer offer1 = new Offer() {OfferName=" 'Buyuk Kış Indirimi' " };
            IOfferService offerService = new AOfferManager();
          
            Game game1 = new Game() { GameName="Gold Digger", Price=1000};
            IGameService gameService = new AGameManager();
            gameService.sell(game1);
            offerService.App(offer1);
            BaseGamerManager gamerManager2 = new AGamerManager(new MernisServiceAdapter());
            gamerManager2.Add(new Gamer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });




        }
    }
}