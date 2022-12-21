using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4
{
    internal class Program
    {
        abstract class Animal
        {
            protected int age;
            protected string food;
            protected string place;
            protected string name;
            public abstract string Food
            {
                get;
                set;
            }
            public abstract int Age
            {
                get;
                set;
            }
            public abstract string Place
            {
                get;
                set;
            }
            public string Name
            {
                get;
                set;
            }
            public abstract void toString();

        }
        class Mammal : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }

        }
        class Reptile : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }
        }
        class Bird : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }
        }
        class Fish : Animal
        {
            public override string Food
            {
                get { return food; }
                set { food = value; }
            }
            public override int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string Place
            {
                get { return place; }
                set { place = value; }
            }
            public override void toString()
            {
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Food: {0}", food);
                Console.WriteLine("Place: {0}", place);
            }
        }


        class Dog : Mammal
        {
            private string dogSound;
            public Dog()
            {
                this.food = "Sausage";
                this.age = 10;
                this.place = "Home";
                dogSound = "Woof Woof";
                Name = "Dog";
            }

            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Sound: {0}", dogSound);
                base.toString();

            }
        }
        class Cat : Mammal
        {
            private string russianName;
            public Cat()
            {
                this.food = "Meat";
                this.age = 10;
                this.place = "Home";
                russianName = "Кошка";
                Name = "Cat";
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("RussianName: {0}", russianName);
                base.toString();

            }
        }


        class Salamander : Reptile
        {
            private string behavior;
            public Salamander()
            {
                this.food = "Maggots";
                this.age = 20;
                this.place = "Forest";
                behavior = "Change body's color";
                Name = "Salamander";
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Behavior: {0}", behavior);
                base.toString();

            }
        }


        class Eagle : Bird
        {
            private int speed;
            public Eagle()
            {
                this.food = "Raw meat";
                this.age = 30;
                this.place = "Sky";
                Name = "Eagle";
                speed = 100;
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Speed: {0}", speed);
                base.toString();

            }
        }
        class Sparrow : Bird
        {
            private int speed;
            public Sparrow()
            {
                this.food = "Grain";
                this.age = 3;
                this.place = "Sky";
                Name = "Sparrow";
                speed = 20;
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Speed: {0}", speed);
                base.toString();

            }
        }


        class Shark : Fish
        {
            private int weight;
            public Shark()
            {
                this.food = "Fish meat";
                this.age = 25;
                this.place = "Ocean";
                Name = "Shark";
                weight = 100;
            }
            public override void toString()
            {
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Weight: {0}", weight);
                base.toString();

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Information about animals:");

            List<Mammal> mammals = new List<Mammal>();
            mammals.Add(new Dog());
            mammals.Add(new Cat());

            List<Bird> birds = new List<Bird>();
            birds.Add(new Eagle());
            birds.Add(new Sparrow());

            List<Reptile> reptiles = new List<Reptile>();
            reptiles.Add(new Salamander());

            List<Fish> fishes = new List<Fish>();
            fishes.Add(new Shark());


            for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Mammal m in mammals)
                {
                    if (Convert.ToInt32(m.Name[0]) == i)
                    {
                        m.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
            for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Bird b in birds)
                {
                    if (Convert.ToInt32(b.Name[0]) == i)
                    {
                        b.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
            for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Reptile r in reptiles)
                {
                    if (Convert.ToInt32(r.Name[0]) == i)
                    {
                        r.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }
                        for (int i = 65; i < 91; i++) // ASCII oder from A->Z
            {
                foreach (Fish f in fishes)
                {
                    if (Convert.ToInt32(f.Name[0]) == i)
                    {
                        f.toString();//Console.WriteLine(m.Name);
                        Console.WriteLine("----------------------------");
                    }
                }
            }


            Console.WriteLine("\nInformation about mammals and birds live more than 5 years:");
            foreach(Mammal m in mammals)
            {
                if (m.Age > 5) Console.WriteLine(m.Name);
            }
            foreach (Bird b in birds)
            {
                if (b.Age > 5) Console.WriteLine(b.Name);
            }

        }
    }

}

