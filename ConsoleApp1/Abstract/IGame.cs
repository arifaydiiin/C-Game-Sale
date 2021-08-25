using ConsoleApp1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    interface IGame
    {
        void sold(Game game,Gamer gamer);
        void soldwithcampaign(Game game, Gamer gamer, Campaign campaign);
 
    }
}
