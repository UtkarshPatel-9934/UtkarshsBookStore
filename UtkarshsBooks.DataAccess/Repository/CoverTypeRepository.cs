using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtkarshsBooks.DataAccess.Repository.IRepository;
using UtkarshsBooks.DataAccess.Repository;
using UtkarshsBooks.Models;
using UtkarshsBookStore.DataAccess.Data;

namespace UtkarshsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
               // _db.SaveChanges();
            }
        }
    }
}
