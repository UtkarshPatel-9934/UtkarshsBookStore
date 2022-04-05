using System;
using System.Linq;
using UtkarshsBooks.DataAccess.Repository.IRepository;
using UtkarshsBooks.Models;
using UtkarshsBookStore.DataAccess.Data;

namespace UtkarshsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product produt)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == produt.Id);
            if(objFromDb != null)
            {
                if(produt.ImageUrl != null)
                {
                    objFromDb.ImageUrl = produt.ImageUrl; // add the check for ImageUrl
                }

                objFromDb.Title = produt.Title;
                objFromDb.Description = produt.Description;
                objFromDb.ISBN = produt.ISBN;
                objFromDb.Author = produt.Author;
                objFromDb.ListPrice = produt.ListPrice;
                objFromDb.CategoryId = produt.CategoryId;
                objFromDb.CoverTypeId = produt.CoverTypeId; // all properties of product object
            }
        }
    }
}
