﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Object_Oriented_Analysis_and_Design.Chapter_Two.Models
{
    public class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void pressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.isOpen())
                door.close();
            else
                door.openDoor();
        }
    }
}