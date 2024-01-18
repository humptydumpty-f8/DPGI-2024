using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8.Використання_в_XAML_класу_локального_простору_імен___Book
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
