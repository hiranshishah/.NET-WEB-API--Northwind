using API1.Model;
using API1.Repository.interfaces;
using API1.services.interfaces;
using System.Data.SqlClient;

namespace API1.Repository
{
    public class CustomerRepo: ICustomerRepo
    {
        string ConnectionString = " ";
        public CustomerRepo()
        {
            ConnectionString = "Data Source=APINP-ELPTYQFAU\\SQLEXPRESS03;Initial Catalog=TrailDB;Persist Security Info=True;User ID=tap2023;Password=tap2023;Encrypt=False;";

        }
        public Customer GetCustomerById(string id)
        {
            Customer c = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = $"Select * from Customers where CustomerID='{id}'";
                SqlCommand cmd= conn.CreateCommand();
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    c=new Customer();
                    c.CustomerId = dr["CustomerID"].ToString();
                    c.CompanyName = dr["CompanyName"].ToString();
                    c.ContactName = dr["ContactName"].ToString();

                }


            }
            return c;
        }
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = $"INSERT INTO Customers (CustomerID, CompanyName, ContactName) VALUES ('{customer.CustomerId}', '{customer.CompanyName}', '{customer.ContactName}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(string id, Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = $"UPDATE Customers SET CompanyName = '{customer.CompanyName}', ContactName = '{customer.ContactName}' WHERE CustomerID = '{id}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(string id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = $"DELETE FROM Customers WHERE CustomerID = '{id}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
            public List<string> GetCustomer()
        {
            throw new NotImplementedException();
        }
    }
    
}
