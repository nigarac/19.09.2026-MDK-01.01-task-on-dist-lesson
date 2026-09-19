using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public  class Parent
    {
        public string number { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string doo {  get; set; }

        public virtual void WarningSound()
        {
            Console.WriteLine("Устройство подаёт сигнал");
        }
    }

    public class Thermometer : Parent
    {
        private double temp { get; set; }

        public void TempSearch()
        {
            temp = new Random().Next(32, 40);
            Console.WriteLine($"Ваша температура = {temp}");
        }

        public override void WarningSound()
        {
            Console.WriteLine("пип-пип-пип");
        }
    }

    public class Weight : Parent
    {
        private double weight { get; set; }

        public void WeightSearch()
        {
            weight = new Random().Next(50, 75);
            Console.WriteLine($"Ваш вес = {weight}");
        }
        public override void WarningSound()
        {
            Console.WriteLine("туру-туру-туру-туру");
        }
    }

    public class Barometr : Parent
    {
        private double bars { get; set; }

        public void BarSearch()
        {
            bars = new Random().Next(50, 75);
            Console.WriteLine($"Давление = {bars}");
        }
        public override void WarningSound()
        {
            Console.WriteLine("бам-бом-бам-бом");
        }
    }
}
