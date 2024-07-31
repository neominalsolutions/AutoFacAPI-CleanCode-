using Architecht.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.EF.Core
{
  public abstract class EFBaseRepository<TContext, TEntity> : IRepository<TEntity> where TContext : DbContext
   where TEntity : Entity
  {
    protected TContext _context;
    protected DbSet<TEntity> _table;
    public EFBaseRepository(TContext context)
    {
      _context = context;
      _table = _context.Set<TEntity>();
    }

    public virtual void Delete(Guid Id)
    {
      var entity = _table.Find(Id);
      ArgumentNullException.ThrowIfNull(entity);
      _table.Remove(entity);
      _context.SaveChanges();
    }

    public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> prediciate)
    {
      return _table.Where(prediciate).AsEnumerable();
    }

    public virtual TEntity FindById(Guid Id)
    {
      var entity = _table.Find(Id);
      ArgumentNullException.ThrowIfNull(entity);

      return entity;
    }

    public virtual void Insert(TEntity entity)
    {
      _table.Add(entity);
      _context.SaveChanges();
    }

    public virtual void Update(TEntity entity)
    {
      _table.Update(entity);
      _context.SaveChanges();
    }
  }
}
