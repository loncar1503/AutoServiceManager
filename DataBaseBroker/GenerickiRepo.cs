using Common.Domain;
using DBBroker;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseBroker
{
    public class GenerickiRepo: IGenerickiRepo
    {

        private Broker2 broker = new Broker2();

        //BROKER-BAZA//
        public void Commit()
        {
            broker.Commit();
        }

        public void OtvoriKonekciju()
        {
            broker.OpenConnection();
        }

        public void ZapocniTransakciju()
        {
            broker.BeginTransaction();
        }

        public void ZatvoriKonekciju()
        {
            broker.CloseConnection();
        }
        public void RollBack()
        {
            broker.Rollback();
        }

        public int Sacuvaj(IEntity objekat)
        {

            SqlCommand cmd = broker.CreateCommand();
            string output = string.IsNullOrWhiteSpace(objekat.Output)
                ? ""
                : $"OUTPUT INSERTED.{objekat.Output}";
            cmd.CommandText = ($"insert into {objekat.NazivTabele} {objekat.Kolone} {output} values ({objekat.Vrednosti})");

            
            if (string.IsNullOrWhiteSpace(objekat.Output))
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            else
            {
                int id = (int)cmd.ExecuteScalar();
                return id;
            }

        }
    }
}
