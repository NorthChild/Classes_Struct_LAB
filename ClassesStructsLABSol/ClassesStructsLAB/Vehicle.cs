using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesStructsLAB;

namespace ClassesStructsLAB
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;



        public int Position { get; private set; }
        public int Speed { get; init; }        
        public int NumPassengers { get; set; }


        public Vehicle()
        {
            throw new System.NotImplementedException();
        }


        public string Move()
        {
            throw new System.NotImplementedException();
        }

    }
}
