using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(T t)
        {
            _appDbContext.Add(t);
            _appDbContext.SaveChanges();
        }

        public void Delete(T t)
        {
            _appDbContext.Remove(t);
            _appDbContext.SaveChanges();
        }

        public List<T> GetList()
        {
            return _appDbContext.Set<T>().ToList();

         }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
