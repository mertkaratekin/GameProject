using MyExercisee.Abstract;
using MyExercisee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameSales.Concretes
{
    public class GamerManager : BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Geçersiz oyuncu bilgileri.");
            }

        }

        public override void Delete(Gamer gamer)
        {
            base.Delete(gamer);
        }

        public override void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Update(gamer);
            }
            else
            {
                Console.WriteLine("Güncelleme başarısız. Geçersiz oyuncu bilgileri.");
            }
        }
    }
}

//namespace MyExercisee.Concrete
//{
//    public class GamerManager : BaseGamerManager
//    {
//        private IGamerCheckService _gamerCheckService;


//        public GamerManager(IGamerCheckService gamerCheckService)
//        {
//            _gamerCheckService = gamerCheckService;
//        }
//        public override void Add(Gamer gamer)
//        {
//            if (_gamerCheckService.CheckIfRealPerson(gamer))
//            {
//                base.Add(gamer);
//            }
//            else
//            {
//                throw new Exception("Not a valid person");
//            }
//        }


//    }
//}
