﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtkarshsBooks.Models;

namespace UtkarshsBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository
    {
        public void Update(Product produt);
    }
}
