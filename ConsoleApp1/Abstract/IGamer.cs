using ConsoleApp1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    interface IGamer
    {
        void Updatedata(Gamer gamer);
        void Deletedata(Gamer gamer);
        void Kayitol(Gamer gamer);
    }
}
