using LessonEntityFramework.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEntityFramework
{
    class Program
    {
        private static void Main(string[] args)
        {
            var customers = GetCustomersEfSqlS();

            foreach (var customer in customers)
            {
                Console.WriteLine("Id: {0}\tName: {1}", customer.CustomerId, customer.CustomerName);
            }
            Console.ReadKey();

            var context = new TestDbContext();

            var transactions = from c in context.Customers
                               join o in context.Orders on c.CustomerId equals o.CustomerId into go
                               from oJoined in go.DefaultIfEmpty()

                               join op in context.OrdersProducts on oJoined.OrderId equals op.OrderId into gop
                               from opJoined in gop.DefaultIfEmpty()

                               join p in context.Products on opJoined.ProductId equals p.ProductId into gp
                               from pJoined in gp.DefaultIfEmpty()

                               group new {c, opJoined,  pJoined}by new {c.CustomerId,c.CustomerName } into g
                               select new
                               {
                                   CustomerName = g.Key.CustomerName,
                                   CustomerSum =
                                        g.Sum(t=>
                                                (t.opJoined == null ? 0: t.opJoined.Count)*
                                                (t.pJoined == null ? 0 : t.pJoined.ProductPrice))
                               };
            foreach (var transaction in transactions)
            {
                string result = string.Format("Customer name: {0}\tSum:{1}", transaction.CustomerName, transaction.CustomerSum);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        private static List<Customer> GetCustomersEf()
        {
            var context = new TestDbContext();

            IEnumerable<Customer> query = context.Customers.Where(x => x.CustomerId == 1);

            var customers = query.ToList();

            return customers;
        }

        private static List<Customer> GetCustomersEfSqlS()
        {
            var context = new TestDbContext();

            var query = from c in context.Customers
                        where c.CustomerId == 1
                        select c;

            var customers = query.ToList();

            return customers;
        }


        private static List<CustomerProxy> GetCustomers()
        {
            using (IDbConnection connection = new SqlConnection(Settings.Default.DbConnect))
            {
                IDbCommand command = new SqlCommand("SELECT * FROM t_customer");
                command.Connection = connection;

                connection.Open();

                IDataReader reader = command.ExecuteReader();
                List<CustomerProxy> customers = new List<CustomerProxy>();
                while (reader.Read())
                {
                    CustomerProxy customer = new CustomerProxy();
                    customer.Id = reader.GetInt32(0);
                    customer.Name = reader.GetString(1);

                    customers.Add(customer);
                }
                return customers;
            }
        }
    }
}
