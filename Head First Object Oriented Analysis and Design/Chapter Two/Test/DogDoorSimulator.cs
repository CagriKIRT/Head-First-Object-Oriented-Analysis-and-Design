using Head_First_Object_Oriented_Analysis_and_Design.Chapter_Two.Models;
using System;

namespace Head_First_Object_Oriented_Analysis_and_Design.Chapter_Two.Test
{
    public class DogDoorSimulator
    {
        public DogDoorSimulator()
        {

        }
        public static void RunSimulator()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.pressButton();
            Console.WriteLine("\nFido has gone outside");
            remote.pressButton();
            Console.WriteLine("\nFido's all done...");
            remote.pressButton();
            Console.WriteLine("\nFido's back inside");
            remote.pressButton();
        }
    }
}