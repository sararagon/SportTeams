using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebApiST.DAL;

namespace WebApiST.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private TeamContext _context = null;
        private DbSet<T> table = null;

        public Repository()
        {
            this._context = new TeamContext();
            table = _context.Set<T>();
        }
        public Repository(TeamContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }


}

