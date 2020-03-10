using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8pratice
{
    class Dog : Animal
    {
        private string favoriteChewToy;

        public Dog(string name, int numOfLegs, int numOfArms, bool isDangerous, bool isFury, string favoriteChewToy)

        {
            //stuff from our base class(parent) Animal
            this.name = name;
            this.numOfLegs = numOfLegs;
            this.numOfArms = numOfArms;
            this.isDangerous = isDangerous;
            this.isFurry = isFury;

            //this is how i can add new stuff my dog can do
            this.favoriteChewToy = favoriteChewToy;

        }

        public void Bark()
        {
            Console.WriteLine("The " + this.GetType() + " goes WOOF WOOF!");
        }

        public override int Sell()
        {
            Console.WriteLine("I love my dog and would never sell it");
            return 0;
        }

    }

}
