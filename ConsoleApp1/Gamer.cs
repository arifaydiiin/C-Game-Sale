using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    class Gamer
    {
        public Gamer(string name,string surname,string identityID,DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            this.identityID = identityID;
            this.birthday = birthday;
        }
        public string name;
        public string surname { get; set; }
        public string identityID { get; set; }
        public DateTime birthday { get; set; }
    }
}
