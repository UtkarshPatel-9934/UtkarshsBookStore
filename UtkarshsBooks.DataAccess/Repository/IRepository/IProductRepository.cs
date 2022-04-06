using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtkarshsBooks.Models;

namespace UtkarshsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
         void Update(Product produt);
       // Product Get(int v);
       // object GetAll(string includeProperties);
       // void Remove(Product objFromDb);
      //  void Add(Product product);
    }
}
