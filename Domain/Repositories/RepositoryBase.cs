using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class, IDbEntity
    {
        DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> AllItems
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public bool AddItem(T item)
        {
            try
            {
                _context.Set<T>().Add(item);
                _context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool AddItems(IEnumerable<T> items)
        {
            try
            {
                _context.Set<T>().AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ChangeItem(T item)
        {
            try
            {
                T modyfying = AllItems.Single(x => x.Id == item.Id);
                modyfying = item;
                _context.SaveChanges();
                return true;               
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteItem(T item)
        {
            try
            {
                _context.Set<T>().Remove(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public T GetItem(int Id)
        {
            return _context.Set<T>().SingleOrDefault(x => x.Id == Id);
        }

        public bool SaveChanges()
        {
            try
            {                
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
