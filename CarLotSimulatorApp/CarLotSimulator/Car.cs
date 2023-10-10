using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car() { }

        public Car(int myYEar, string myMake, string myModel, string myEngineNoise, string myHonkNoise, bool isMyDrivable) {
            Year = myYEar;
            Make = myMake;
            Model = myModel;
            EngineNoise = myEngineNoise;
            HonkNoise = myHonkNoise;
            IsDriveable= isMyDrivable;
        }

        //make engine noise
        public void MakeEngineNoise(string engine) { Console.WriteLine($"{engine} "); }

        //make honk noise
        public void MakeHonkNoise(string honk) { Console.WriteLine($"{honk} "); }
    }
}
