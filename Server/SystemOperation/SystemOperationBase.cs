using DBBroker;
using Microsoft.EntityFrameworkCore.Storage;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public abstract class SystemOperationBase
    {
       // protected readonly Broker broker;
        public  AppDbContext context;
        private IDbContextTransaction transaction;

        public SystemOperationBase()
        {
            context = new AppDbContext();

        }

        public void ExecuteTemplate()
        {        
            try
            {
                //broker.BeginTransaction();
                transaction= context.Database.BeginTransaction();
                ExecuteConcreteOperation();
                context.SaveChanges();
                transaction?.Commit();
                // broker.Commit();
            }
            catch (Exception)
            {
                transaction?.Rollback();
                throw;
            }
            finally
            {
                transaction?.Dispose();
                context.Dispose();
            }
        }
        protected abstract void ExecuteConcreteOperation();
    }
}
