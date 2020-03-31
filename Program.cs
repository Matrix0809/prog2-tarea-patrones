using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Shallow
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { Nombre = "Chivo", Patas = 4 };
            Animal animalClonado = animal.Clone() as Animal;
            animalClonado.Patas = 3;

            Console.WriteLine(animal.Patas);

            Console.ReadKey();
        }
    }
}
