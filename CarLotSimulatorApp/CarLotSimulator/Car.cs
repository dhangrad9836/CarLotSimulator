using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {

        //constructor
        //default constructor
        public Car() { }

        //constructor with parameters
        public Car(int year, string make, string model, string engineNoise, 
            string honkNoise, bool isDriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        //Properties of Car
        public int Year {  get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable {  get; set; }

        //Methods 
        public static string MakeEngineNoise(string EngineNoise)
        {
            return EngineNoise;
        }

        public static string MakeHonkNoise(string HonkNoise)
        {
            return HonkNoise;
        }






    }
}
