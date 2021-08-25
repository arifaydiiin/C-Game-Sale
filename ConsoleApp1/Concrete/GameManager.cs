using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    class GameManager : IGame
    {
     

        public void sold(Game game,Gamer gamer)
        {
            Console.WriteLine(gamer.name + " adlı oyuncu" + game.gamename + " adli oyunu+ "+ game.gameprice+ " Tl ye satın aldı");
        }
        public void soldwithcampaign(Game game, Gamer gamer, Campaign campaign)
        {
            
            Console.WriteLine(gamer.name + " adlı oyuncu" + game.gamename + " adli oyunu " + (game.gameprice - (game.gameprice * campaign.campaignvalue) / 100) + " Tl ye yüzde " + campaign.campaignvalue + " indirimle satın aldı");
        }
    
    }
}
