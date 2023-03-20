using MyExercisee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyExercisee.Abstract
{
    public interface ISaleService
    {
        void Information(Gamer gamer, Offer offer, Game game);
    }
}
