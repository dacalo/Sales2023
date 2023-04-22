using Sales.Mobile.MVVM.Models;
using SQLite;
using System.Linq.Expressions;

namespace Sales.Mobile.MVVM.Repository
{
    public class CustomerRepository
    {
        private readonly SQLiteConnection _connection;

        public CustomerRepository()
        {
            _connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            _connection.CreateTable<Customer>();
        }

        public string StatusMessage { get; set; }

        public void AddOrUpdate(Customer customer)
        {
            try
            {
                int result = 0;
                if (customer.Id == 0)
                {
                    result = _connection.Insert(customer);
                    StatusMessage = $"{result} row(s) added.";
                }
                else
                {
                    result = _connection.Update(customer);
                    StatusMessage = $"{result} row(s) updated.";
                }
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
            }
        }

        public List<Customer> GetAll()
        {
            try
            {
                return _connection.Table<Customer>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
                return null;
            }
        }

        public List<Customer> GetAll2()
        {
            try
            {
                return _connection.Query<Customer>("SELECT * FROM Customers").ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
                return null;
            }
        }

        public Customer Get(int id)
        {
            try
            {
                return _connection.Table<Customer>().FirstOrDefault(c => c.Id == id);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var customer = Get(id);
                _connection.Delete(customer);
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> predicate)
        {
            try
            {
                return _connection.Table<Customer>()
                    .Where(predicate)
                    .ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error {ex.Message}.";
                return null;
            }
        }

    }
}
