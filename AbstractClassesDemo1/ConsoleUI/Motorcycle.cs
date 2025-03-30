using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is blazing through traffic....");//throw new NotImplementedException();
        }

        public override void DriveVirtual()//unlike abstract marked methods written into an abstract parent class, special member methods, virtual or otherwise, stubbed, or otherwise, won't be required to get carried over from that abstract base class into any of its potential derived classes inheriting from it, even if they're not marked as abstract classes themselves. So, in such a case as this, manually writing out the same method in its original syntax is required, or just copy and paste it as I did from the base abstract method in which it was written.
        {
            Console.WriteLine("The motorcycle's drive method....");
        }

        //public override void Testing1()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
