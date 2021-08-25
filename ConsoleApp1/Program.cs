using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer("Arif","Aydın","123", new DateTime(2013, 1, 23));
            Gamer gamer2 = new Gamer("Ahmet", "Yıldız", "1234", new DateTime(2013, 1, 23));
            Game game1 = new Game("Counter Strike",100);
            Game game2 = new Game("Witcher 3", 50);
            Campaign campaign1 = new Campaign("%40 indirim",40);
            Campaign campaign2 = new Campaign("%20 indirim", 20);
            Campaign campaign3 = new Campaign("%100 indirim", 100);
            GameManager gamemanager1 = new GameManager();
            gamemanager1.soldwithcampaign(game1, gamer1, campaign1);
            gamemanager1.soldwithcampaign(game1, gamer2, campaign2);
            gamemanager1.soldwithcampaign(game2, gamer1, campaign3);
            GamerManager gamerManager = new GamerManager();
            gamerManager.Kayitol(gamer1);

            Console.ReadLine();
            

        }
    }
}
