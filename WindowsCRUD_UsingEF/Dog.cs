using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCRUD_UsingEF
{
    public class Dog
    {
        public int Id { get; set; }
        public string DogName { get; set; }
        public decimal Weight { get; set; }

        public string FavoriteFood { get; set; }
    }
}
