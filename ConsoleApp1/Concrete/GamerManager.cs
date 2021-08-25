using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    class GamerManager : IGamer
    {
        public void Deletedata(Gamer gamer)
        {
            Console.WriteLine(gamer.name+" adlı kullanıcının verileri silindi.");
        }

        public void Kayitol(Gamer gamer)
        {
            Console.WriteLine(gamer.name + " adlı kullanıcı kayıt oldu");
        }

        public void Updatedata(Gamer gamer)
        {
            Console.WriteLine(gamer.name + " adlı kullanıcının verileri güncellendi.");
        }
    }
}
