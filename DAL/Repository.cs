using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        EscuelaPruebaEntities Context = null;
        public Repository()
        {
            Context = new EscuelaPruebaEntities();
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {
                //NOS PERMITE ACCCEDER AL ENTITY ACTUAL
                return Context.Set<TEntity>();
            }
        }
        public TEntity Create(TEntity toCreate)
        {
            TEntity result = null;
            try
            {
                EntitySet.Add(toCreate);
                Context.SaveChanges();
                result = toCreate;
            }
            catch(Exception e)
            {

            }
            return result;
            //throw new NotImplementedException();
        }
        public bool Delete(TEntity toDelete)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(toDelete);
                EntitySet.Remove(toDelete);
                result = Context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                var error = e.ToString();
            }
            return result;
        }

        public void Dispose()
        {
            if(Context != null)
            {
                Context.Dispose();
            }
            //throw new NotImplementedException();
        }

        public List<TEntity> Filter(Expression<Func<TEntity, bool>> criteria)
        {
            List<TEntity> result = new List<TEntity>();
            try
            {
                result = EntitySet.Where(criteria).ToList();
            }
            catch (Exception e)
            {
                var error = e.ToString();
            }
            return result;
            //throw new NotImplementedException();
        }

        public TEntity Retrieve(Expression<Func<TEntity, bool>> criteria)
        {
            TEntity result = null;
            try
            {
                result = EntitySet.FirstOrDefault(criteria);
            }
            catch (Exception e)
            {
                var error = e.ToString();
            }
            return result;
            //throw new NotImplementedException();
        }

        public List<TEntity> RetrieveAllOrder(Expression<Func<TEntity, string>> criteria)
        {
            List<TEntity> Result = null;
            try
            {
                Result = EntitySet.OrderBy(criteria).ToList();
            }
            catch(Exception e)
            {
                var error = e.ToString();
            }
            return Result;
        }

        public bool Update(TEntity toUpdate)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(toUpdate);
                Context.Entry<TEntity>(toUpdate).State = EntityState.Modified;
                result = Context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                var error = e.ToString();
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}
