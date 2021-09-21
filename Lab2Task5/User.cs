using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task5
{
    class User
    {
        public string login { set; get; }
        public string name { set; get; }
        public string secondname { set; get; }
        public int age { set; get; }
        public DateTime date { get; }
        public User()
        {
            date = DateTime.Now;
        }
    }
}
