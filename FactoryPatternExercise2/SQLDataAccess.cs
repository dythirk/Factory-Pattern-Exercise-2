using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from an SQL database.");
            var payload = new Product();
            Console.WriteLine($"Data point Name: {payload.Name}");
            Console.WriteLine($"Data point Price: {payload.Price}");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to an SQL database.");
        }
    }
}
