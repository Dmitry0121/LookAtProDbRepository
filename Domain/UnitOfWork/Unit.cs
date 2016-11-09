using Domain.Abstract;
using Domain.EF;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitOfWork
{
    static public class Unit
    {
        private static MyDatabaseContext _context;

        public static IRepositoryBase<Product> Products
        {
            get;
            private set;
        }

        public static IRepositoryBase<Category> Categories
        {
            get;
            private set;
        }

        static Unit()
        {
            _context = new MyDatabaseContext("MyConnStr");

            Products = new RepositoryBase<Product>(_context);
            Categories = new RepositoryBase<Category>(_context);
        }
    }
}
