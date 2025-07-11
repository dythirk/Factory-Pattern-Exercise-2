﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a list database.");
            var payload = new Product();
            Console.WriteLine($"Data point Name: {payload.Name}");
            Console.WriteLine($"Data point Price: {payload.Price}");
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a list database.");
        }
    }
}
