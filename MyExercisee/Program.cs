using MyExercisee.Abstract;
using MyExercisee.Entities;
using MyExercisee.Concrete;
using MernisServiceReference;
using System;
using MyExercisee.Adapters;
using GameSales.Concretes;

namespace MyExercisee
{
    class Program
    {
        private static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer{Id = 1, FirstName = "Engin", LastName = "Demiroğ",DateOfBirth = new DateTime(1985, 1,6 ), NationalityId = "28861499108" };
            Game game1 = new Game { Id = 1, Name = " 'Gold Digger' ", Price = 250 };
            Offer offer1 = new Offer { OfferName = " 'Buyuk Kış Indırımı' " };

            IGamerService gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            Console.WriteLine("*******************************************************************");
            IGameService gameService = new GameManager();
            gameService.Add(game1);
            Console.WriteLine("*******************************************************************");

            IOfferService offerManager = new OfferManager();
            offerManager.Add(offer1);
            Console.WriteLine("*******************************************************************");

            ISaleService saleManager = new SaleManager();
            saleManager.Information(gamer1,offer1,game1);
          

        }
    }
}