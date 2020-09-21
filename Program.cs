using System;

namespace XayDungLopAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal animal2 = new Animal("Tiger", "Meo meo");

            animal.GetInfo();
            
            animal2.GetInfo();
        }
    }
}
