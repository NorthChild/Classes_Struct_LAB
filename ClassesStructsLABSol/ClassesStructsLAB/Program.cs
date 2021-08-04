using System;

namespace ClassesStructsLAB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(5, 40);

            //Console.WriteLine(car.Speed);
            //Console.WriteLine(car.numPassengers);
            //Console.WriteLine(car.Position);



            Aeroplane a = new Aeroplane(200, 100, "JetsRUS") { numPassengers = 150 };

            a.Ascend(150);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);
        }
    }
}
