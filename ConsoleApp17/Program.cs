﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage G = new Garage(new List<string>() { "Honda", "Suzuki" });
            G.AddCar(null);

        }
    }
}
