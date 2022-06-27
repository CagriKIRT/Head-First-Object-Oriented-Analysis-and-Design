using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Object_Oriented_Analysis_and_Design.Chapter_Two.Models
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }

        public void openDoor()
        {
            Console.WriteLine("The dog doors opens");
            open = true;
        }

        public void close()
        {
            Console.WriteLine("The dog door closes");
            open = false;
        }

        public bool isOpen() => open;
    }
}