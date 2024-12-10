using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCRUD_UsingEF
{
    public class DogRepository : IRepository<Dog>
    {
        private readonly MyDogsContext _context;

        public DogRepository(MyDogsContext context)
        {
            _context = context;
        }

        public IEnumerable<Dog> GetAll()
        {
            return _context.MyDogs.ToList();
        }

        public Dog GetById(int id)
        {
            return _context.MyDogs.Find(id);
        }

        public void Add(Dog dog)
        {
            _context.MyDogs.Add(dog);
            _context.SaveChanges();
        }

        public void Update(Dog dog)
        {
            _context.MyDogs.Update(dog);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var dog = _context.MyDogs.Find(id);
            if (dog != null)
            {
                _context.MyDogs.Remove(dog);
                _context.SaveChanges();
            }
        }
    }
}
