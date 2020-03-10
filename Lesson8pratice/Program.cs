using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Fido", 4, 0, false, true, "Dog Bone");
            myDog.Bark();
            myDog.Eat();
            myDog.Sleep();

        }
    }
    


}
