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

        public int Position { get; private set; } = 0;
        public int Speed { get; init; }        

        public int numPassengers
        {
            get { return _numPassengers; } 
            set
            {
                if (-numPassengers > _capacity)
                {
                    throw new ArgumentOutOfRangeException("Too many on board!");
                }
                else if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Only positive int allowed");
                }

                _numPassengers = value;
            }
        }

        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
            if (capacity < 0)
            {
                throw new ArgumentException();
            }
        }

        public virtual string Move(int times)
        {
            Position = Speed * times;
            return $"Moving along {times} times";
        }

        public string Move()
        {
            Position = Speed;
            return "Moving along";
        }





        //public Vehicle(int capacity, int speed)
        //{


        //}

        //public Vehicle() {

        //}


        //public string Move()
        //{
        //    // takes the speed and adds it to the position
        //    throw new System.NotImplementedException();
        //}


        //public string Move(int times)
        //{
        //    return $"Moving along {times} times";
        //}

    }
}
