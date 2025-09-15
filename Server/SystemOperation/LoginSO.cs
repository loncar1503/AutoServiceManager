using Common.Domain;
using DBBroker;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class LoginSO :SystemOperationBase
    {
        
        private readonly Majstor m;
        public Majstor Result { get; set; }
        //private readonly AppDbContext context;


        public LoginSO(Majstor m)
        {           
            this.m = m;
           // context = new AppDbContext();

        }


        protected override void ExecuteConcreteOperation()
        {
            Result = context.Majstori.FirstOrDefault(ma => ma.Username == m.Username && ma.Password == m.Password);
            if ( Result== null)
            {
                throw new Exception("Username and password are incorrect.");
            }
        }
        //protected void ExecuteConcreteOperation()
        //{
        //    string condition = $"username = '{z.Username}' AND password = '{z.Password}'";
        //    List<IEntity> lista = broker.GetByCondition(z, condition);

        //    Result = lista.Cast<Zaposleni>().FirstOrDefault();

        //    if (Result == null)
        //    {
        //        throw new Exception("Ne postoji zaposleni sa unetim kredencijalima.");
        //    }

        //}
    }
}
