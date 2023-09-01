using Demo.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Demo2.infra.EF
{
    public interface IUnitofWork
    {
        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity :class;
    }
    public class DemoContext: DbContext,IUnitofWork
    {



        public DbSet<Student> Students { get; set; }

        int IUnitofWork.SaveChanges()
        {
            return this.SaveChanges();
        }

        DbSet<TEntity> IUnitofWork.Set<TEntity>()
        {
            return this.Set<TEntity>();
        }
    }
}
