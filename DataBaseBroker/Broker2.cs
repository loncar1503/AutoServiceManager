using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker2
    {
        SqlConnection connection;
        SqlTransaction transaction;

        public Broker2()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Automehanicar;Integrated Security=True");
        }

        public SqlCommand CreateCommand()
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            return command;
        }

        public void OpenConnection()
        {
            connection.Open();


        }
        public void CloseConnection()
        {
            if (connection != null & connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();

        }
        public void Commit()
        {
            if (transaction != null)
            {
                transaction.Commit();
            }
        }
        public void Rollback()
        {
            if (transaction != null)
            {
                transaction.Rollback();


            }
        }

    }
}

