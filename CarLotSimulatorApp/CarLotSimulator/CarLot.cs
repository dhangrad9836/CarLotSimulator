using System;
using System.Collections.Generic;


namespace CarLotSimulator
{
    public class CarLot
    {
        //default constructor
       public CarLot() { }

        //public CarLot(List<Car> cars) 
        //{
        //    Cars = cars;
        //}

        //properties
        //note that we use public so we can acces it outside of this CarLot class
        //public List<Car> Cars { get; set; }
        //our list of cars
        public List<Car> Cars = new List<Car>();
    }
}
