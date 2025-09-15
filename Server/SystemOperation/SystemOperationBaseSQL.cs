using DataBaseBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public abstract class SystemOperationBaseSQL
    {
        public void IzvrsiSO(object obj)
        {
            try
            {
                repo.OtvoriKonekciju();
                repo.ZapocniTransakciju();

                Validacija(obj);
                Izvrsi(obj);

                repo.Commit();
            }
            catch(Microsoft.Data.SqlClient.SqlException ex)
            {
                throw new Exception("This registration already exists");
            }
            catch (Exception ex)
            {
                repo.RollBack();
                throw new Exception("Greška prilikom izvršenja sistemske operacije: " + ex.Message);
            }
            finally
            {
                repo.ZatvoriKonekciju();
            }
        }

        protected virtual void Validacija(object obj) { }

        protected abstract void Izvrsi(object obj);

        protected IGenerickiRepo repo = new GenerickiRepo();
 
    }
}
