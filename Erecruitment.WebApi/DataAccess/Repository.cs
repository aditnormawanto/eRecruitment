using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Erecruitment.WebApi.DataAccess
{
    public class Repository<tEntity> where tEntity : class
    {
        protected eRecruitmentEntities _context;
        
        public Repository()
        {
            _context = new eRecruitmentEntities();
        }
        
        public tEntity Get(int id)
        {
            return _context.Set<tEntity>().Find(id);
        }
        
        public async Task<tEntity> GetAsync(int id)
        {
            return await _context.Set<tEntity>().FindAsync(id);
        }
        
        public ICollection<tEntity> GetAll()
        {
            return _context.Set<tEntity>().ToList();
        }
        
        public async Task<ICollection<tEntity>> GetAllAsync()
        {
            return await _context.Set<tEntity>().ToListAsync();
        }
        
        public tEntity Find(Expression<Func<tEntity, bool>> match)
        {
            return _context.Set<tEntity>().SingleOrDefault(match);
        }
        
        public async Task<tEntity> FindAsync(Expression<Func<tEntity, bool>> match)
        {
            return await _context.Set<tEntity>().SingleOrDefaultAsync(match);
        }
        
        public ICollection<tEntity> FindAll(Expression<Func<tEntity, bool>> match)
        {
            return _context.Set<tEntity>().Where(match).ToList();
        }
        
        public async Task<ICollection<tEntity>> FindAllAsync(Expression<Func<tEntity, bool>> match)
        {
            return await _context.Set<tEntity>().Where(match).ToListAsync();
        }
        
        public tEntity Add(tEntity t)
        {
            _context.Set<tEntity>().Add(t);
            _context.SaveChanges();
            return t;
        }
        
        public async Task<tEntity> AddAsync(tEntity t)
        {
            _context.Set<tEntity>().Add(t);
            await _context.SaveChangesAsync();
            return t;
        }
        
        public IEnumerable<tEntity> AddAll(IEnumerable<tEntity> tList)
        {
            _context.Set<tEntity>().AddRange(tList);
            _context.SaveChanges();
            return tList;
        }
        
        public async Task<IEnumerable<tEntity>> AddAllAsync(IEnumerable<tEntity> tList)
        {
            _context.Set<tEntity>().AddRange(tList);
            await _context.SaveChangesAsync();
            return tList;
        }
        
        public tEntity Update(tEntity updated, int key)
        {
            if (updated == null)
                return null;

            tEntity existing = _context.Set<tEntity>().Find(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                _context.SaveChanges();
            }
            return existing;
        }
        
        public async Task<tEntity> UpdateAsync(tEntity updated, int key)
        {
            if (updated == null)
                return null;

            tEntity existing = await _context.Set<tEntity>().FindAsync(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                await _context.SaveChangesAsync();
            }
            return existing;
        }
        
        public void Delete(tEntity t)
        {
            _context.Set<tEntity>().Remove(t);
            _context.SaveChanges();
        }
        
        public async Task<int> DeleteAsync(tEntity t)
        {
            _context.Set<tEntity>().Remove(t);
            return await _context.SaveChangesAsync();
        }
        
        public int Count()
        {
            return _context.Set<tEntity>().Count();
        }
        
        public async Task<int> CountAsync()
        {
            return await _context.Set<tEntity>().CountAsync();
        }
    }
}