using MyApplication.Abstract;
using MyApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Concrete
{
    public class AGameManager : IGameService
    {
        public void sell(Game game)
        {
            Console.Write(game.GameName + "isimli oyun ");
        }
    }
}
