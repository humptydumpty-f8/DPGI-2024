using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10.Створення_в_ресурсі_колекції_ArrayList_елементів_Book
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public override string ToString()
        {
            return string.Format("{0} by {1}\nPublished {2}", Name, Author, YearPublished);
        }
    }
}
